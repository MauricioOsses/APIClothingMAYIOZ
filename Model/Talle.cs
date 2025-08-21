using System.ComponentModel.DataAnnotations;

namespace APIClothingMAYIOZ.Model
{
    public class Talle
    {
        [Key]
        public int IdTalle { get; set; }
        public string? NombreTalle { get; set; }
    }
}
