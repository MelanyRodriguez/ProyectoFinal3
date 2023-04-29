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
    public class Empleado
    {
        public int EmpleadoID { get; set; }
        public string EmpleadoCedula { get; set; }
        public string EmpleadoNombre { get; set; }
        public string EmpleadoApellido { get; set; }
        public int EmpleadoEdad { get; set; }
        public string EmpleadoCorreo { get; set; }
        public string EmpleadoContrasennia{ get; set; }
        public string EmpleadoDireccion { get; set; }


        public EmpleadoRol MiRolTipo { get; set; }
        

        public Empleado()
        //Crear una instancia en la clase producto
        {
           MiRolTipo= new EmpleadoRol();
        }
        //Funciones y metodos
        public Empleado ValidarEmpleado(string pCorreo,string pContrasennia)
        {
            Empleado R= new Empleado();

            Conexion MiCnn = new Conexion();
         Crypto crypto = new Crypto();
         string ContrasenniaEncriptada=crypto.EncriptarEnUnSentido(pContrasennia);


         MiCnn.ListaDeParametros.Add(new SqlParameter("@correo",pCorreo));
         MiCnn.ListaDeParametros.Add(new SqlParameter("@contrasennia", ContrasenniaEncriptada));

            //necesito un datatable para capturar la info del empleado
            DataTable dt = new DataTable();
            dt = MiCnn.EjecutarSELECT("SPEmpleadoValidarIngreso");

            if (dt != null && dt.Rows.Count > 0)
            {
                //esta consulta deberia tener solo un registro, se crea un objeto de tipo Data Row 
                //para capturar la info contenida en index 0 del datatable (dt)

                DataRow dr = dt.Rows[0];

                R.EmpleadoID = Convert.ToInt32(dr["EmpleadoID"]);
                R.EmpleadoCedula= Convert.ToString(dr["EmpleadoCedula"]);
                R.EmpleadoNombre = Convert.ToString(dr["EmpleadoNombre"]);
                R.EmpleadoApellido = Convert.ToString(dr["EmpleadoApellido"]);
                R.EmpleadoEdad = Convert.ToInt32(dr["EmpleadoCedula"]);
                R.EmpleadoCorreo = Convert.ToString(dr["EmpleadoCorreo"]);
                R.EmpleadoDireccion = Convert.ToString(dr["EmpleadoDireccion"]);
                R.EmpleadoContrasennia = string.Empty;

                //Composiciones
                R.MiRolTipo.EmpleadoRolID = Convert.ToInt32(dr["EmpleadoRolID"]);
                R.MiRolTipo.EmpleadoRolDescripcion = Convert.ToString(dr["EmpleadoRolDescripcion"]);

            }


            return R;
        }











    }


}
