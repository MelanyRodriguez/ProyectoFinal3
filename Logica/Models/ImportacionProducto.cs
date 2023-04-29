using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class ImportacionProducto
    {
        //propiedades
        public decimal Cantidad { get; set; }
        public decimal CostoUnitario { get; set; }

        //composicion simple 
        public Producto MiProducto { get; set; }

        //constructor

        public ImportacionProducto() { 

            MiProducto = new Producto();
        }
    }


}
