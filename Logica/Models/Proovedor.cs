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
    public class Proovedor
    {

        public int ProovedorID { get; set; }
        public string ProovedorNombre { get; set; }
        public string ProovedorCedula { get; set; }
        public string ProovedorEmail { get; set; }
        public string ProovedorDireccion { get; set; }
        public string ProovedorTelefono { get; set; }
        public bool Activo { get; set; }
        //Propiedades Compuestas
        public TipoProovedor MiTipoProovedor { get; set; }

        public Proovedor()
        //Crear una instancia en la clase producto
        {
            MiTipoProovedor = new TipoProovedor();
        }
        //Funciones y metodos

        public DataTable Listar(bool VerActivos=true, string FiltroBusqueda="")

        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();
            MiCnn.ListaDeParametros.Add(new SqlParameter("@VerActivos", VerActivos));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@FiltroBusqueda", FiltroBusqueda));

            R = MiCnn.EjecutarSELECT("SPProovedorListar");
            return R;
        }

       public DataTable ListarActivos()

        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            //como el SP tiene un parametro debemos definir ese parametro en la lista de parametros
            //del objeto de conexion
            MiCnn.ListaDeParametros.Add(new SqlParameter("@VerActuales", true));
            R = MiCnn.EjecutarSELECT("SPProovedorListarActuales");
            return R;
        }

        public DataTable ListarInActivos()

        {
            DataTable R = new DataTable();
            return R;
        }

        public bool Agregar ()
        {
            bool R=false;

            Conexion MiCnn =new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Nombre", this.ProovedorNombre));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Cedula", this.ProovedorNombre));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Correo", this.ProovedorNombre));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Direccion", this.ProovedorNombre));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@IdTipo ", this.MiTipoProovedor.TipoProovedorID));

            int resultado = MiCnn.EjecutarInsertUpdateDelete("SPProovedorAgregar");

            if (resultado >0)
            {
                R = true;
            }
            return R;
        }
        

    }
}
