using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class CategoriaProducto
    {
        public int CategoriaProductoID { get; set; }
        public string CategoriaProductoDescripcion { get; set; }

        //luego las funciones y metodos
        //Se realiza codigo para listar las categorias de los productos
        public DataTable Listar()
        {
            DataTable R = new DataTable();

            Services.Conexion MiCnn= new Services.Conexion();
            R = MiCnn.EjecutarSELECT("SPCategoriaProductoListar");
            return R;
        }








    }
}
