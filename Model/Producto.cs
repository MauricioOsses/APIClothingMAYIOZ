using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIClothingMAYIOZ.Model
{
    public class Producto

    {
        [Key]
        public int IdProducto { get; set; }
        public string? Nombre { get; set; }
        public int IdMarca { get; set; }
        public int IdTalle { get; set; }
        public int IdGenero { get; set; }
        public decimal? Precio { get; set; }

        [ForeignKey("IdMarca")]
        public Marca Marca { get; set; }

        [ForeignKey("IdTalle")]
        public Talle Talle { get; set; }

        [ForeignKey("IdGenero")]
        public Genero Genero { get; set; }


    }
}
