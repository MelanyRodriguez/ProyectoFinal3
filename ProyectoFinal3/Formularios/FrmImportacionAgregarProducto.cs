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
    public partial class FrmImportacionAgregarProducto : Form


    {

        DataTable ListaProductos { get; set; }
        Producto MiProductoLocal { get; set; }
        public FrmImportacionAgregarProducto()
        {
            InitializeComponent();

            ListaProductos= new DataTable();
            MiProductoLocal=new Producto();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {

         if (DgvLista.SelectedRows.Count==1)

            {
                // se extraen los valores del producto en la fila seleccionada 
                DataGridViewRow row = DgvLista.SelectedRows[0];
                int ProductoID = Convert.ToInt32(row.Cells["CProductoID"].Value);
                string NombreProducto = Convert.ToString(row.Cells["CProductoNombre"].Value);
                decimal Precio= Convert.ToDecimal(row.Cells["CProductoCostoUnitario"].Value);
                decimal Cantidad = NumUDCantidad.Value;

                //se crea una nueva fila del DataTable de detalle del formulario de registro
                //de importaciones y ademas se le asignan los valores recolectados

                DataRow MiFila= Globales.MiFormRegistroDeImportaciones.ListaProductos.NewRow();

                MiFila["ProductoID"] = ProductoID;
                MiFila["ProductoNombre"] = NombreProducto;
                MiFila["CostoUnitario"] = Precio;
                MiFila["Cantidad"] = Cantidad;

                Globales.MiFormRegistroDeImportaciones.ListaProductos.Rows.Add(MiFila);

                DialogResult = DialogResult.OK;
            }

           
        }

        private void FrmImportacionAgregarProducto_Load(object sender, EventArgs e)
        {
            LlenarLista();
        }

        private void LlenarLista ()

        {
            ListaProductos = new DataTable();
            ListaProductos = MiProductoLocal.ListarEnBusqueda();
            DgvLista.DataSource= ListaProductos;
            DgvLista.ClearSelection();
        }
    }
}
