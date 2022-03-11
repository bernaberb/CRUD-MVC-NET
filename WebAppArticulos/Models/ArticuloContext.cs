using Microsoft.EntityFrameworkCore;

namespace WebAppArticulos.Models
{
    //Creamos el contexto
    public class ArticuloContext : DbContext
    {
        public ArticuloContext(DbContextOptions<ArticuloContext> options) 
            : base(options)
        {
        }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Producto> Productos { get; set; }
    }
}
