using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using api_aspnetcore_iroxit.DAL;
using api_aspnetcore_iroxit.Entities;
using Newtonsoft.Json;

namespace api_aspnetcore_iroxit.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentasController : ControllerBase
    {
        private readonly IroxitContext _context;

        public VentasController(IroxitContext context)
        {
            _context = context;
        }

        // GET: api/Ventas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ventas>>> GetVentas()
        {
            return await _context.Ventas.ToListAsync();
        }

        // GET: api/Ventas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Ventas>> GetVentas(int id)
        {
            var ventas = await _context.Ventas.FindAsync(id);

            if (ventas == null)
            {
                return NotFound();
            }

            return ventas;
        }

        // GET: api/Ventas/Articulo
        [HttpGet("Articulo")]
        public async Task<List<VentasArticulo>> GetVentasArticulo()
        {
                var query = from a in _context.Ventas
                            join b in _context.Productos on a.IDProductos equals b.IDProductos
                            select new VentasArticulo
                            {
                                Titulo = b.Titulo,
                                CantidadVendida = a.CantidadVendida,
                                Monto = (a.CantidadVendida * b.PrecioUnitario)
                            };

                return await query.ToListAsync();
        }


        private bool VentasExists(int id)
        {
            return _context.Ventas.Any(e => e.IDVentas == id);
        }
    }
}
