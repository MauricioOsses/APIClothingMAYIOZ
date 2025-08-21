using APIClothingMAYIOZ.DTO_s;
using APIClothingMAYIOZ.Model;
using APIClothingMAYIOZ.Repositories.InterfazRepository;

namespace APIClothingMAYIOZ.Repositories.ProductoRepository
{
    public interface IProductoRepository : IRepositoryBase<Producto>
    {
        Task<IEnumerable<ProductoDetalleDTO>> GetProductoDetalle(); 
        Task<ProductoDetalleDTO> GetProductoDetalleById(int id); 
    }
}
