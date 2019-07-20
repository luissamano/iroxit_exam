using api_aspnetcore_iroxit.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace api_aspnetcore_iroxit.DAL
{
    public class IroxitContext : DbContext
    {
        public DbSet<Productos> Productos { get; set; }
        public DbSet<Ventas> Ventas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                connectionString:
                @"Server=DESKTOP-M3J6UFC\SQLEXPRESS;Database=db_iroxit;Trusted_Connection=False;User Id=sa;Password=7soe600@;Trusted_Connection=False;MultipleActiveResultSets=true;");
        }
    }
}
