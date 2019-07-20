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
}
