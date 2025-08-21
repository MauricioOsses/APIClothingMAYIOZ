using APIClothingMAYIOZ.DTO_s;
using APIClothingMAYIOZ.Model;
using APIClothingMAYIOZ.Repositories.ProductoRepository;
using APIClothingMAYIOZ.Services.IServiceBase;

namespace APIClothingMAYIOZ.Services.ServiceProducto
{
    public class ProductoService : ServiceBase<Producto>, IProductoService
    {
        private readonly IProductoRepository _repo;
        public ProductoService(IProductoRepository repo): base(repo)
        {
            _repo = repo;
        }

        public async Task<IEnumerable<ProductoDetalleDTO>> GetProductoDetalle()
        {
            return await _repo.GetProductoDetalle();
        }

        public async Task<ProductoDetalleDTO> GetProductoDetalleById(int id)
        {
            return await _repo.GetProductoDetalleById(id);
        }
    }
}
