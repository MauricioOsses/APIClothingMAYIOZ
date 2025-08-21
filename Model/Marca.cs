using System.ComponentModel.DataAnnotations;

namespace APIClothingMAYIOZ.Model
{
    public class Marca
    {
        [Key]
        public int IdMarca { get; set; }
        public string? NombreMarca { get; set; }
    }
}
