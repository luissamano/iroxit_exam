using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_aspnetcore_iroxit
{
    public class Ventas
    {
        [Key]
        public int IDVentas { get; set; }    
        public int IDProducto { get; set; }
        [Required]    
        public int CantidadVendida { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime Fecha { get; set; }

        
        [ForeignKey("IDProducto")]
        public Productos Producto { get; set; }
    }
}