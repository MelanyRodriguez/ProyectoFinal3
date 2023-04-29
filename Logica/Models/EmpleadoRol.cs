using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class EmpleadoRol
        //primero se escriben los atributos 
    {
        public int EmpleadoRolID { get; set; }   
        public string EmpleadoRolDescripcion { get; set; }

        //luego las funciones y metodos

        public DataTable Listar()
        {
            DataTable R= new DataTable();

            Services.Conexion MiCnn = new Services.Conexion();
            R = MiCnn.EjecutarSELECT("SPEmpleadoRolListar");


            return R;
        }
    }
}
