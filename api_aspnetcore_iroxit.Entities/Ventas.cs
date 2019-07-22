using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace api_aspnetcore_iroxit.Entities
{
     public class Ventas
    {
        [Key]
        public int IDVentas { get; set; }
        public int IDProductos { get; set; }
        [Required]    
        public int CantidadVendida { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime Fecha { get; set; }     
    }


    public class VentasArticulo
    {
        public string Titulo { get; set; }
        public int CantidadVendida { get; set; }
        public decimal Monto { get; set; }
    }
}
