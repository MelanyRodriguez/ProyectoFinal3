using Logica.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Producto
    {
        public int ProductoID { get; set; }
        public string ProductoNombre { get; set; }
        public string ProductoColor { get; set; }
        public string ProductoTamanio { get; set; }
        public int CategoriaProductoID { get; set; }
        public string CategoriaProductoDescripcion { get; set; }
        public int ProductoCostoUnitario { get; set; }
        public int ImportacionID { get; set; }
        public bool Activo { get; set; }
        //Propiedades Compuestas
        public CategoriaProducto MiTipoProducto { get; set; }

        public Producto()
        //Crear una instancia en la clase producto
        {
            MiTipoProducto = new CategoriaProducto();
        }
        //Funciones y metodos

        public bool Agregar()
        {
            
            bool R = false;
            //pasos 1.6.1 y 1.6.2
          Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Nombre", this.ProductoNombre));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Color", this.ProductoColor));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Tamanio", this.ProductoTamanio));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Costo", this.ProductoCostoUnitario));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@IdImportacion", this.ImportacionID));
            //normalmente los foreign keys tienen que ver con composiciones, en este caso
            //tenemos que extraer el valor del objeto compuesto 'MiPipoProducto'
            MiCnn.ListaDeParametros.Add(new SqlParameter("@IdCategoria", this.MiTipoProducto.CategoriaProductoID));

            // pasos 1.6.3 y 1.6.4
            int resultado = MiCnn.EjecutarInsertUpdateDelete("SPProductoGuardar");

            // paso 1.6.5
            if (resultado>0)
            {
                R= true;
            }
         

            return R;
        }

        public bool Editar()
        {
            
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Nombre", this.ProductoNombre));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Color", this.ProductoColor));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Tamanio", this.ProductoTamanio));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Costo", this.ProductoCostoUnitario));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@IdImportacion", this.ImportacionID));
            //normalmente los foreign keys tienen que ver con composiciones, en este caso
            //tenemos que extraer el valor del objeto compuesto 'MiPipoProducto'
            MiCnn.ListaDeParametros.Add(new SqlParameter("@IdCategoria", this.MiTipoProducto.CategoriaProductoID));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.ProductoID));
            int resultado = MiCnn.EjecutarInsertUpdateDelete("SPProductoModificar ");

            
            if (resultado > 0)
            {
                R = true;
            }

            return R;
        }
        public bool Eliminar()
        {
            
            bool R = false;

        Conexion MiCnn = new Conexion();
            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.ProductoID));
            int respuesta = MiCnn.EjecutarInsertUpdateDelete("SPProductoDesactivar");
            if ( respuesta > 0)
            {
                R = true;
            }

            return R;
        }

    public bool Activar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();
            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.ProductoID));
            int respuesta = MiCnn.EjecutarInsertUpdateDelete("SPProductoActivar");
            if (respuesta > 0)
            {
                R = true;
            }


            return R;
        }






        public bool ConsultarPorID()
        {
            //Solo si la operacion sale correcta se retorna la operacion a true
            bool R = false;

            Conexion MiCnn = new Conexion();
            MiCnn.ListaDeParametros.Add(new SqlParameter("ID", this.ProductoID));

            //necesito un datatable para capturar la info del usuario
            DataTable dt = new DataTable();
            dt = MiCnn.EjecutarSELECT("SPProductoConsultarPorID");

            if (dt != null && dt.Rows.Count > 0)
            {

                R = true;
            }

            return R;
        }

        public Producto ConsultarPorIDRetornaProducto()
        {
            
            Producto R = new Producto();

          Conexion MiCnn = new Conexion();
            MiCnn.ListaDeParametros.Add(new SqlParameter("ID", this.ProductoID));

            //necesito un datatable para capturar la info del usuario
            DataTable dt = new DataTable();
            dt = MiCnn.EjecutarSELECT("SPProductoConsultarPorID");

            if (dt != null && dt.Rows.Count>0)
            {
              //esta consulta deberia tener solo un registro, se crea un objeto de tipo Data Row 
              //para capturar la info contenida en index 0 del datatable (dt)

                DataRow dr= dt.Rows[0];

                R.ProductoID= Convert.ToInt32(dr["ProductoID"]);
                R.ProductoNombre = Convert.ToString(dr["ProductoNombre"]);
               R.ProductoColor = Convert.ToString(dr["ProductoColor"]);
                R.ProductoTamanio = Convert.ToString(dr["ProductoTamanio"]);
                R.ProductoCostoUnitario= Convert.ToInt32(dr["ProductoCostoUnitario"]);
                R.ImportacionID = Convert.ToInt32(dr["ImportacionID"]);

                //Composiciones
                R.MiTipoProducto.CategoriaProductoID = Convert.ToInt32(dr["CategoriaID"]);
                R.MiTipoProducto.CategoriaProductoDescripcion = Convert.ToString(dr["CategoriaDescripcion"]);

            }
                



            return R;
        }

        public bool ConsultarPorNombre()
        {
            //paso 1.3.1 y 1.3.2
            Conexion MiCnn = new Conexion();
           //agregamos el parametro de nombre 
           MiCnn.ListaDeParametros.Add(new SqlParameter("@Nombre",this.ProductoNombre));

            DataTable consulta = new DataTable();

            bool R = false;
            //paso 1.3.3 y 1.3.4
            consulta = MiCnn.EjecutarSELECT("SPProductoConsultarPorNombre");

            //paso 1.3.5
            if (consulta != null && consulta.Rows.Count>0)
            {
                R = true;
            }

            return R;
        }

        public DataTable ListarActivos(string pFiltroBusqueda) {
             
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();
            // en este caso como el SP tiene parametros debemos definir ese parametro en la 
            //lista de parametros en la clase conexion

            MiCnn.ListaDeParametros.Add(new SqlParameter("@VerActivos",true));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@FiltroBusqueda", pFiltroBusqueda));
            R = MiCnn.EjecutarSELECT("SPProductoListar");


        return R;
    }
        public DataTable ListarInactivos(string pFiltroBusqueda)
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();
            // en este caso como el SP tiene parametros debemos definir ese parametro en la 
            //lista de parametros en la clase conexion

            MiCnn.ListaDeParametros.Add(new SqlParameter("@VerActivos", false));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@FiltroBusqueda", pFiltroBusqueda));
            R = MiCnn.EjecutarSELECT("SPProductoListar");


            return R;
        }

        public DataTable ListarEnBusqueda ()
        {
            DataTable R = new DataTable();
            Conexion MiCnn = new Conexion();

            R = MiCnn.EjecutarSELECT("SPProductoBusquedaListar");
            return R;
        }








    }
     

       

 


    }




 

