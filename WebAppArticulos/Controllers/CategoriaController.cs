using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using WebAppArticulos.Models;

namespace WebAppArticulos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly ArticuloContext _context;
        public CategoriaController(ArticuloContext context)
        {
            _context = context;
        }

        // GET: api/<CategoriaController>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                //Creamos una variable para el listado
                var categorias = _context.Categorias
                    .Include(cat => cat.Productos)
                    .ToList();
                //Cremos una variable anónima donde agregaremos los productos de las categorias a devolver
                var catProductos = categorias.Select(cat => new
                {
                    Id = cat.CategoriaId,
                    Nombre = cat.Nombre,
                    Descripcion = cat.Descripcion,
                    Producto = cat.Productos.Select(prod => new
                    {
                        Id = prod.ProductoId,
                        Nombre = prod.Nombre,
                        Descripcion = prod.Descripcion,
                        FechaCreacion = prod.FechaCreacion,
                        FechaModificacion = prod.FechaModificacion,
                        Codigo = prod.Codigo,
                        PrecioUnitario = prod.PrecioUnitario,
                        Stock = prod.Stock,
                    }).ToList()
                }).ToList();
                //Retornamos losproductos de la categoria
                return Ok(catProductos);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}