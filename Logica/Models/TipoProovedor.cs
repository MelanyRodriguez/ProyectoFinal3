using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class TipoProovedor
    {
        public int TipoProovedorID { get; set; }
        public string TipoProovedorDescripcion { get; set; }

        //luego las funciones y metodos

        public DataTable Listar()
        {
            DataTable R = new DataTable();

         Services.Conexion MiCnn = new Services.Conexion();
            R = MiCnn.EjecutarSELECT("SPProovedorTipoListar ");




            return R;
        }
    }
}
