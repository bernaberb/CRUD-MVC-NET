using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using WebAppArticulos.DAO;

namespace WebAppArticulos.Controllers

{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriasDaoController : ControllerBase
    {
        private readonly ILogger<ProductosDao> _logger;
        public CategoriasDaoController(ILogger<ProductosDao> logger)
        {
            _logger = logger;
        }

        // GET: api/<CategoriasDaoController>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                DAO.ProductosDao dao = new DAO.ProductosDao(_logger);
                var categorias = dao.ObtenerCategorias();
                return Ok(categorias);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}