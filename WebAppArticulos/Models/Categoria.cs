using System.Collections.Generic;

namespace WebAppArticulos.Models
{
    //Clase categorías. Cada categoría puede tener muchos productos (pero cada producto sólo una categoría). Se vinculan por el ID de la categoría.
    public class Categoria
    {
        public long CategoriaId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Eliminado { get; set; }
        public List<Producto> Productos { get; set; }
    }
}
