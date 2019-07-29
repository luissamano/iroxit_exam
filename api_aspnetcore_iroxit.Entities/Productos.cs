using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace api_aspnetcore_iroxit.Entities
{
    public class Productos
    {
        [Key]
        public int IDProductos { get; set; }
        [StringLength(200)]
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioUnitario { get; set; }
        public int Existencias { get; set; }
    }


    public class TopProductos
    {
        public int IDProductos { get; set; }
        public string Titulo { get; set; }
        public int CantidadVendida { get; set; }
    }

    public class Products
    {
        public int idProductos { get; set; }
        public string titulo { get; set; }
        public string descripcion { get; set; }
        public decimal precioUnitario { get; set; }
        public int existencias { get; set; }
    }
}
