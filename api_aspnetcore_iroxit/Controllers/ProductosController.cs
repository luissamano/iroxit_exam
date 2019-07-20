﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using api_aspnetcore_iroxit.DAL;
using api_aspnetcore_iroxit.Entities;

namespace api_aspnetcore_iroxit.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        private readonly IroxitContext _context;

        public ProductosController(IroxitContext context)
        {
            _context = context;
        }

        // GET: api/Productos
        [HttpGet]
        public async Task<List<Productos>> GetProductos()
        {
            return await _context.Productos.ToListAsync();
        }

        // GET: api/Productos/5
        [HttpGet("{id}")]
        public async Task<Productos> GetProductos(int id)
        {
            var productos = await _context.Productos.FindAsync(id);

            if (productos == null)
            {
                return productos;
            }

            return productos;
        }

    }
}
