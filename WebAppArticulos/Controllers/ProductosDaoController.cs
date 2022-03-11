using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppArticulos.DAO;

namespace WebAppArticulos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosDaoController : ControllerBase
    {
        private readonly ILogger<ProductosDao> _logger;
        public ProductosDaoController(ILogger<ProductosDao> logger)
        {
            _logger = logger;
        }

        //Obtenemos los productos cargados
        // GET: api/<ProductosDaoController>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                DAO.ProductosDao dao = new DAO.ProductosDao(_logger);
                var productos = dao.ObtenerProductos();
                return Ok(productos);
            }
            //Atajamos la posible excepción
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

    }
}
