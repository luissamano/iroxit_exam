using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_aspnetcore_iroxit.Models
{
    public class Productos 
    {
        [Key]
        public int IDProducto { get; set;}
        [Required]
        public string Titulo { get; set;}
        [StringLength(200)]
        public string Descripcion  { get; set;}
        [Required]
        public decimal PrecioUnitario { get; set;}
        [Required]
        public int Existencias { get; set;}
    }    
}