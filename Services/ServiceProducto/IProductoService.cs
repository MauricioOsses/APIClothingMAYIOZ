using APIClothingMAYIOZ.DTO_s;
using APIClothingMAYIOZ.Model;
using APIClothingMAYIOZ.Services.IServiceBase;

namespace APIClothingMAYIOZ.Services.ServiceProducto
{
    public interface IProductoService: IServiceBase<Producto>
    {
        Task<IEnumerable<ProductoDetalleDTO>> GetProductoDetalle();
        Task<ProductoDetalleDTO> GetProductoDetalleById(int id);
    }
}
