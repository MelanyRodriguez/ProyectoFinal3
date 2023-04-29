using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal3.Formularios
{
    public partial class FrmGestionProductos : Form { 

    //por orden es mejor crear objetos locales que permitan la gestion del tema 
    //que estamos tratando, usar objetos individuales puede provocar desorden y complicar
    //la lectura del codigo fuente 


      //objeto local para el producto
      private Logica.Models.Producto MiProductoLocal { get; set;}

        //lista local de usuarios que se visualiza en en datagridview
        private DataTable ListaProductos { get; set;}


        public FrmGestionProductos()
        {
            InitializeComponent();

            MiProductoLocal= new Logica.Models.Producto();
        }

        private void FrmGestionProductos_Load(object sender, EventArgs e)
        {
            //Definir el padreMDI
            MdiParent = Globales.MiFormPrincipal;
            Cargarlistacategorias();
            CargarListaDeProductos();
            ActivarAgregar();
        }
        //Diseñamos el cargar lista de categorias para que se muestre en la pantalla
        //las dos categorias de la base de datos

        private void CargarListaDeProductos()
        {
            //recetear la lista de productos haciendo re instancia  del objeto
            ListaProductos= new DataTable();

            // si en el cuadro de texto  de busqueda hay 3 o mas caracteres se filtra la lista 
            string FiltroBusqueda = "";

            if (!string.IsNullOrEmpty(TxtBuscar.Text.Trim())&& TxtBuscar.Text.Count() >= 3)
            {
                FiltroBusqueda= TxtBuscar.Text.Trim();

            }


            if (CboxVerActivos.Checked)
            {
                ListaProductos = MiProductoLocal.ListarActivos(FiltroBusqueda);
            }
            else
            {
                ListaProductos = MiProductoLocal.ListarInactivos(FiltroBusqueda);
            }
            DgLista.DataSource = ListaProductos;
        }



        private void Cargarlistacategorias()
        {
            Logica.Models.CategoriaProducto MiCategoria= new Logica.Models.CategoriaProducto();
            DataTable dt = new DataTable();
            dt = MiCategoria.Listar();
            if(dt!= null && dt.Rows.Count > 0 )
            {
                CbcategoriaProducto.ValueMember = "ID";
                CbcategoriaProducto.DisplayMember = "Descrip";
                CbcategoriaProducto.DataSource = dt;
                CbcategoriaProducto.SelectedIndex = -1;
            }

            
            
            



        }

        private void DgLista_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DgLista.ClearSelection();
        }

        private void DgLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //cuando seleccionamos una fila del datagrid se debe cargar la info de dicho producto
            // en el producto local y luego dibujar esa info en los controles graficos
          if (DgLista .SelectedRows.Count == 1 )
            {
                LimpiarFormulario();

                //de la coleccion de filas seleccionadas seleccionamos la fila con indice 0
                //osea la primera

                DataGridViewRow MiFila = DgLista.SelectedRows[0];
                //lo que necesitamos es el valor del ID del producto para realizar la consulta 
                //y traer todos los datos para llenar el objeto de producto local
                int IdProducto = Convert.ToInt32(MiFila.Cells["CProductoID"].Value);

                //para no asumir rriesgos se instancia el Producto local
                MiProductoLocal = new Logica.Models.Producto();
                
                //ahora le agregamos el valor obtenido por la fila al ID del producto local
                MiProductoLocal.ProductoID= IdProducto;

                //una vez que tengo el objeto local con el valor del id , puedo ir a consultar
                //el producto por ese ID y llenar el resto de los atributos 
                MiProductoLocal = MiProductoLocal.ConsultarPorIDRetornaProducto();

                //Validamos que el producto local tenga datos 
                if (MiProductoLocal!= null && MiProductoLocal.ProductoID>0)
                {
                    //si cargamos correctamente el producto local llenamos los controles 
                    TxtProductoID.Text = Convert.ToString(MiProductoLocal.ProductoID);
                    TxtProductoNombre.Text = MiProductoLocal.ProductoNombre;
                    TxtProductoColor.Text = MiProductoLocal.ProductoColor;
                    ProductoTamanio.Text = MiProductoLocal.ProductoTamanio;
                    TxtProductoCosto.Text = Convert.ToString(MiProductoLocal.ProductoCostoUnitario);
                    TxtImportacionID.Text = Convert.ToString(MiProductoLocal.ImportacionID);

                    //combobox
                    CbcategoriaProducto.SelectedValue = MiProductoLocal.MiTipoProducto.CategoriaProductoID;
                    ActivarEditarEliminar();
                }
            }
        
        }

        private bool ValidarDatosDigitados()
        {
            //Evalua que haya digitado los campos en el formulario
            bool R = false;

            if (!string.IsNullOrEmpty(TxtProductoNombre.Text.Trim()) &&
                ! string.IsNullOrEmpty(TxtProductoColor.Text.Trim()) &&
                !string.IsNullOrEmpty(ProductoTamanio.Text.Trim()) &&
                ! string.IsNullOrEmpty(TxtProductoCosto.Text.Trim()) &&
                ! string.IsNullOrEmpty(lblmportacionID.Text.Trim()) &&
                CbcategoriaProducto.SelectedIndex>-1)
            {
                R = true;

            }
           else
            {
                // que pasa si algo

                //nombre 
                if (string.IsNullOrEmpty(TxtProductoNombre.Text.Trim()))
                {
                    MessageBox.Show("debe digitar un nombre para el producto", "Error de validacion", MessageBoxButtons.OK);
                    TxtProductoNombre.Focus();
                    return false;
                }


                // Color
                if (string.IsNullOrEmpty(TxtProductoColor.Text.Trim()))
                {
                    MessageBox.Show("debe digitar un color para el producto", "Error de validacion", MessageBoxButtons.OK);
                    TxtProductoColor.Focus();
                    return false;
                }

                // Tamaño
                if (string.IsNullOrEmpty(ProductoTamanio.Text.Trim()))
                {
                    MessageBox.Show("debe digitar un tamaño para el producto", "Error de validacion", MessageBoxButtons.OK);
                    ProductoTamanio.Focus();
                    return false;
                }

                // Costo
                if (string.IsNullOrEmpty(TxtProductoCosto.Text.Trim()))
                {
                    MessageBox.Show("debe digitar un costo para el producto", "Error de validacion", MessageBoxButtons.OK);
                    TxtProductoCosto.Focus();
                    return false;
                }

                // Importacion
                if (string.IsNullOrEmpty(lblmportacionID.Text.Trim()))
                {
                    MessageBox.Show("debe digitar un id de importacion para el producto", "Error de validacion", MessageBoxButtons.OK);
                    lblmportacionID.Focus();
                    return false;
                }

                // categoria del producto

                if (CbcategoriaProducto.SelectedIndex==-1)
                {
                    MessageBox.Show("debe digitar una categoria para el producto", "Error de validacion", MessageBoxButtons.OK);
                    CbcategoriaProducto.Focus();
                    return false;
                }

            }



            return R;
        }
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            DgLista.ClearSelection();
            ActivarAgregar();
        }

        private void ActivarAgregar()
        {
            BtnAgregar.Enabled = true;
            BtnModifiar.Enabled = false;
            BtnEliminar.Enabled = false;
        }

        private void ActivarEditarEliminar()
        {
            BtnAgregar.Enabled = false;
            BtnModifiar.Enabled = true;
            BtnEliminar.Enabled = true;
        }
        private void LimpiarFormulario()
        {
            TxtProductoID.Clear();
            TxtProductoNombre.Clear();
            TxtProductoColor.Clear();
            TxtTamanio.Clear();
            TxtImportacionID.Clear();
            TxtProductoCosto.Clear();
            CbcategoriaProducto.SelectedIndex = -1;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
         
           if (ValidarDatosDigitados())
            {

            
            //estas variables almacenan el resultado de las consultas por ID y NOMBRE
           
            bool NombreOK;

            //pasos 1.1 y 1.2
            MiProductoLocal = new Logica.Models.Producto();

         //llenar los valores con los datos digitados en el Form
            MiProductoLocal.ProductoNombre= TxtProductoNombre.Text.Trim();
            MiProductoLocal.ProductoColor=  TxtProductoColor.Text.Trim();
            MiProductoLocal.ProductoTamanio= ProductoTamanio.Text.Trim();
            MiProductoLocal.ProductoCostoUnitario = Convert.ToInt32(TxtProductoCosto.Text.Trim());
            MiProductoLocal.ImportacionID= Convert.ToInt32(TxtImportacionID.Text.Trim());
                //Composicion de categoria
                MiProductoLocal.MiTipoProducto.CategoriaProductoID = Convert.ToInt32(CbcategoriaProducto.SelectedValue);

            //Realizar las consultas por ID y por NOMBRE
            //pasos 1.3 y 1.3.6
            //IDOK = MiProductoLocal.ConsultarPorID();

            //pasos 1.4 y 1.4.6

            NombreOK = MiProductoLocal.ConsultarPorNombre();

            //paso 1.5
            if ( NombreOK ==false)
            {
                //se puede agregar un producto ya que no existe un producto con el nombre y el 
                //id digitados 
                //se solicita al usuario si quiere agregar un producto o no 


                string msg = string.Format("¿Esta seguro que desea agregar el producto?{0}", MiProductoLocal.ProductoNombre);
                DialogResult respuesta = MessageBox.Show(msg, "???", MessageBoxButtons.YesNo);
                if (respuesta == DialogResult.Yes )
                {
                    bool ok = MiProductoLocal.Agregar();

                    if ( ok )
                    {
                        MessageBox.Show("Producto guardado correctamente", ":)", MessageBoxButtons.OK);

                        LimpiarFormulario();
                        CargarListaDeProductos();

                    }
                    else 
                    {
                        MessageBox.Show("El producto no se pudo guardar", ":/", MessageBoxButtons.OK);

                    }


                }

            }

            else
            {
                //indicar al usuario si falta alguna consulta


               //// if (IDOK)
               // {
               //     MessageBox.Show("ya existe un producto con ese ID", "Error de validacion", MessageBoxButtons.OK);
               //     return;
               // }


                if (NombreOK)
                {
                    MessageBox.Show("ya existe un producto con ese nombre", "Error de validacion", MessageBoxButtons.OK);
                    return;
                }






            }











        }
    }

        private void BtnModifiar_Click(object sender, EventArgs e)
        {

           if (ValidarDatosDigitados())
            {
                //no es necesario captucturar el id desde el cuadro de texto ya que al consultarlo
                //(cuando seleccionamos el producto del datagrid),ya tenemos en el ID
                //Este ID  no se puede modificar los demas atributos si 

                MiProductoLocal.ProductoNombre = TxtProductoNombre.Text.Trim();
                MiProductoLocal.ProductoColor= TxtProductoColor.Text.Trim();
                MiProductoLocal.ProductoTamanio= ProductoTamanio.Text.Trim();
                MiProductoLocal.ProductoCostoUnitario= Convert.ToInt32(TxtProductoCosto.Text.Trim());
                MiProductoLocal.ImportacionID = Convert.ToInt32(TxtImportacionID.Text.Trim());
                //Composicion de categoria de producto
                MiProductoLocal.MiTipoProducto.CategoriaProductoID = Convert.ToInt32(CbcategoriaProducto.SelectedValue);

                //segun el diagrama de caso de uso expandido es habitual consultar por el IDel item que 
                //se va a modificar, para asegurarse que en el lapso de tiempo entre el que selecciono
                //el usuario y el que se modificaron los datos en pantalla aun existan los registros en la base de datos 
                //porque puede ser que ya no esten en ella

                if (MiProductoLocal.ConsultarPorID())
                {

                    DialogResult respuesta = MessageBox.Show("Esta seguro de modificar el producto", "???",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if(respuesta == DialogResult.Yes)
                    {
                        if (MiProductoLocal.Editar())
                        {
                            MessageBox.Show("El producto ha sido modificado correctamente", ":)", MessageBoxButtons.OK);
                            LimpiarFormulario();
                            CargarListaDeProductos();
                        }
                    }

                }


            }

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
          if (MiProductoLocal.ProductoID > 0 && MiProductoLocal.ConsultarPorID())
            {
                //Este boton podra servir tanto como para activar y desactivar productos activos
                // el chclbox de la parte superior del formulario me sirve para desactivar 
                //esta accion

                if (CboxVerActivos.Checked)
                {
                    //DESACTIVAR PRODUCTO
                    DialogResult r = MessageBox.Show("¿Esta seguro de eliminar el producto?",
                                                      "???",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {
                        if (MiProductoLocal.Eliminar())

                        {
                            MessageBox.Show("El producto ha sido eliminado correctamente", "!!!", MessageBoxButtons.OK);
                            LimpiarFormulario();
                            CargarListaDeProductos();
                        }
                    }
                }
                else
                {
                    //ACTIVAR PRODUCTO

                    DialogResult r = MessageBox.Show("¿Esta seguro de Activar el producto?",
                                                        "???",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {
                        if (MiProductoLocal.Activar())

                        {
                            MessageBox.Show("El producto ha sido activado correctamente", "!!!", MessageBoxButtons.OK);
                            LimpiarFormulario();
                            CargarListaDeProductos();
                        }

                    }

                   
                 }

            }

        }
        private void TxtProductoNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e, true);
        }

        private void TxtProductoColor_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e, true);
        }

        private void Tamanio_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e, true);
        }

        private void TxtProductoCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresNumeros(e, true);
        }

        private void ImportacionID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresNumeros(e, true);
        }

        private void CboxVerActivos_CheckedChanged(object sender, EventArgs e)
        {
            CargarListaDeProductos();

            if (CboxVerActivos.Checked)
            {
                BtnEliminar.Text = "ELIMINAR";
            }

            else
            {
                BtnEliminar.Text = "ACTIVAR";
            }



        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarListaDeProductos();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}