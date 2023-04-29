using Logica.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class ImportacionTipo
    {
        public int ImportacionTipoID { get; set; }
        public string ImportacionTipoDescripcion { get; set; }

        //luego las funciones y metodos

        public DataTable Listar()
        {
            DataTable R = new DataTable();
          
            return R;
        }
    }
}
