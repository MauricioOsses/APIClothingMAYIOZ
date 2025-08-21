using System.ComponentModel.DataAnnotations;

namespace APIClothingMAYIOZ.Model
{
    public class Genero
    {
        [Key]
        public int IdGenero { get; set; }
        public string? NombreGenero { get; set; }
    }
}
