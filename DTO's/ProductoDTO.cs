namespace APIClothingMAYIOZ.DTO_s
{
    public class ProductoDTO
    { 
        public string Nombre { get; set; } = string.Empty;
        public int IdMarca { get; set; }
        public int IdTalle { get; set; }
        public int IdGenero { get; set; }
        public decimal Precio { get; set; }
    }
}
