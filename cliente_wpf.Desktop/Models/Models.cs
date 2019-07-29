using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cliente_wpf.Desktop.Models
{
    class Models
    {
        public class Products
        {
            public int idProductos { get; set; }
            public string titulo { get; set; }
            public string descripcion { get; set; }
            public decimal precioUnitario { get; set; }
            public int existencias { get; set; }
        }

        public class Ventas
        {
            public int idVentas { get; set; }
            public int idProductos { get; set; }
            public int cantidadVendida { get; set; }
            public DateTime fecha { get; set; }
        }

        public class VentasArticulo
        {
            public string titulo { get; set; }
            public int cantidadVendida { get; set; }
            public decimal monto { get; set; }
        }
        public class TopProductos
        {
            public int idProductos { get; set; }
            public string titulo { get; set; }
            public int cantidadVendida { get; set; }
        }
    }
}
