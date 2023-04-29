using Logica.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{ 
    //propiedades
    public class Importacion
    {
       public int ImportacionID { get; set; }
        public string Dia { get; set; }
        public string Lugar { get; set; }
       public string Mes { get; set; }

        //composiciones simples 
       public  ImportacionTipo MiimportacionTipo { get; set; }
        public Proovedor MiTipoProovedor { get; set; }
        public Producto MiProducto { get; set; }

        //composiciones en lista o complejas 

        public List<ImportacionProducto> ImportacionesProductos { get; set; }

        //constructor 

        public Importacion() {
          MiimportacionTipo = new ImportacionTipo();
            MiTipoProovedor = new Proovedor();
            MiProducto= new Producto();
            ImportacionesProductos = new List<ImportacionProducto>();
    }

     public DataTable CargarEsquemaImporacion()
        {
            DataTable R = new DataTable();
            Conexion MiCnn = new Conexion();
            R = MiCnn.EjecutarSELECT("SPImportacionEsquema",true);
            
            //como estamos cargando el esquema ,tambien viene la indicacion del PK 
            //se debe anular esta opcion

            R.PrimaryKey = null;
            return R;

        }
        //funcion para agregar en el encabezado detalle

        public bool Agregar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@IDProovedor", this.MiTipoProovedor.ProovedorID));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@IDProducto", this.MiProducto.ProductoID));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@IDImportacionTipo", this.MiimportacionTipo.ImportacionTipoID));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@IDImportacion", this.ImportacionID));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Dia", this.Dia));

            Object retorno = MiCnn.EjecutarSELECTEscalar("SPImportacionAgregar");

            //como la devolucion puede ser de varios tipos (int,string,decimal) se captura
            //la respuesta de un Object y luego se hace la convercion al tipo correcto

            int IDCreada;

            if (retorno != null)

            {
                try
                {
                    IDCreada = Convert.ToInt32(retorno.ToString());

                    this.ImportacionID= IDCreada;

                    //Se procede a hacer los inserts en el detalle 

                    foreach (ImportacionProducto item in this.ImportacionesProductos)
                    {

                        Conexion MiCnnDetalle= new Conexion();
                        MiCnnDetalle.ListaDeParametros.Add(new SqlParameter("@IDImportacion", IDCreada));
                        MiCnnDetalle.ListaDeParametros.Add(new SqlParameter("@IDProducto", item.MiProducto.ProductoID));
                        MiCnnDetalle.ListaDeParametros.Add(new SqlParameter("@Cantidad", item.Cantidad));
                        MiCnnDetalle.ListaDeParametros.Add(new SqlParameter("@Precio", item.CostoUnitario));

                        MiCnnDetalle.EjecutarSELECTEscalar("SPImportacion_ProductoAgregar");
                        
                    }
                    R = true;













                }
                    catch (Exception)
                {
                    throw;
                }
            }










            return R;
        }


    }
}
