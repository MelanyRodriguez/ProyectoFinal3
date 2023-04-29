using Logica.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal3.Formularios
{
    public partial class FrmRegistrodeImportaciones : Form
    {

     public Importacion MiImportacionLocal { get; set; }

        public DataTable ListaProductos { get; set; }

        public FrmRegistrodeImportaciones()
        {
            InitializeComponent();

            MiImportacionLocal= new Importacion();
            ListaProductos= new DataTable();
        }

       

        private void FrmRegistrodeImportaciones_Load(object sender, EventArgs e)
        {
            MdiParent = Globales.MiFormPrincipal;
            LimpiarForm();
        }

        private void LimpiarForm()
        {
            TxtProovedorNombre.Clear();
            TxtDia.Clear();
            TxtMes.Clear();
            TxtTotal.Text = "0";
            TxtTotalCantidad.Text = "0";

            //se debe cargar un esquema de detalle de la lista de productos de la tabla 
            //importacion_producto para saber como se llaman  lso campos que tipo de datos 
            //y que pueda servir de datasourse en el DgvLista

            ListaProductos = new DataTable();
            ListaProductos = MiImportacionLocal.CargarEsquemaImporacion();
            DgvLista.DataSource = ListaProductos;

        }





        private void BtnBuscarProovedor_Click(object sender, EventArgs e)
        {
            //se abre un nuevo formulario de busqueda de proodedor
            Form FormBusquedaProovedor = new FrmProovedorBuscar();
            DialogResult respuesta = FormBusquedaProovedor.ShowDialog();

            if (respuesta == DialogResult.OK)
            {
                //usamos las composiciones a proovedor para extraer el valor del nombre del proovedoor
                NombreProovedor.Text = MiImportacionLocal.MiTipoProovedor.ProovedorNombre;
            }



        }

        private void BtnImportacionAgregar_Click(object sender, EventArgs e)
        {
            Form MiFormBusquedaItem = new FrmImportacionAgregarProducto();
            DialogResult respuesta = MiFormBusquedaItem.ShowDialog();
            if (respuesta == DialogResult.OK)
            {
                DgvLista.DataSource = ListaProductos;
            }
        }

      private void Totalizar()
        {
            //se usa para mostrar los totales 
            if (ListaProductos.Rows.Count > 0)
            {
                //se realizan operaciones matematticas 

                decimal TotalItems = 0;
                decimal TotalMonto = 0;

                foreach (DataRow row in ListaProductos.Rows)
                {
                    TotalItems += Convert.ToDecimal(row["Cantidad"]);
                    //total itrms = total items + algo

                    TotalMonto += Convert.ToDecimal(row["CostoUnitario"]) * Convert.ToDecimal(row["Cantidad"]);
                }
                TxtTotalCantidad.Text = TotalItems.ToString();
                //este formato sirve para representar un valor monetatio {0:C2}
                TxtTotal.Text = string.Format("{0:C2}", TotalMonto);









        }
        }

      

        private void BtnCrearImportacion_Click(object sender, EventArgs e)
        {
            //primero se valida que haya digitado un proovedor
            //y que haya como minimo una linea en el detalle


           if (ValidarCompra())
            {
                //los pasos para agregar el encabezado detalle son:
                //1. realizar el insert en el encabezado y recolectar el ID recien creado
                //teniendo claro que ese ID lo genera la base de datos

                //2. Con ese ID y el id del producto tenemos las dos FK para hacer el insert en la 
                //tabla detalle

                //se agregar los datos en el encabezado que hacen falta
                MiImportacionLocal.Dia= TxtDia.Text.Trim();
                MiImportacionLocal.Mes = TxtMes.Text.Trim();

                //como estoy ingredando con un boton de ingreso rapido en el login no tengo datos
                //en el producto global por lo pronto el ID estara quemado

                MiImportacionLocal.MiProducto.ProductoID = 2;
                TrasladoImportacionListaVusualAObjetoCompra();

                //a este punto tenemos armado el objeto de Importacion Local

                if (MiImportacionLocal.Agregar())

                {
                    MessageBox.Show("Compra creada correctamente", "(:", MessageBoxButtons.OK);

                    LimpiarForm();
                }
            }

        }

        private void TrasladoImportacionListaVusualAObjetoCompra()
        {
            //pasamos los datos que se usan graficamente a la List al objeto MiImportacionLocal
            foreach (DataRow fila in ListaProductos.Rows)
            {
                ImportacionProducto nuevaImportacionProducto= new ImportacionProducto();
                nuevaImportacionProducto.MiProducto.ProductoID = Convert.ToInt32(fila["ProductoProductoID"]);
                nuevaImportacionProducto.Cantidad = Convert.ToDecimal(fila["Cantidad"]);
                nuevaImportacionProducto.CostoUnitario = Convert.ToDecimal(fila["CostoUnitario"]);

                //una vez tenemos los datos en el nuevo detalle se agrega ese objeto a la 
                //lista de detalles de la importacion Local

                MiImportacionLocal.ImportacionesProductos.Add(nuevaImportacionProducto);

            }
        }

        private bool ValidarCompra()
        {
            bool R=false;

          if (!string.IsNullOrEmpty(TxtProovedorNombre.Text.Trim()) && 
                ListaProductos.Rows.Count >0)
            {
                R= true;
            }

          else
            {
                if (string.IsNullOrEmpty(TxtProovedorNombre.Text.Trim()))
                {
                    MessageBox.Show("se debe seleccionar un proovedor", "Error en la validacion", MessageBoxButtons.OK);
                    return false;
                }

                if (ListaProductos.Rows.Count==0)
                {
                    MessageBox.Show("Debe haber al menos una fila en el detalle", "Error en la validacion", MessageBoxButtons.OK);
                    return false;
                }


            }




            return R;
        }
    }

}
