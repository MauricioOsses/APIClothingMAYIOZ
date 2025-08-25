using APIClothingMAYIOZ.Data;
using APIClothingMAYIOZ.DTO_s;
using APIClothingMAYIOZ.Model;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace APIClothingMAYIOZ.Repositories.ProductoRepository
{
    public class ProductoRepository : RepositoryBase<Producto>, IProductoRepository
    {
        private readonly IMapper _mapper;
        public ProductoRepository(ClothingDbContext context, IMapper mapper) : base(context)
        {
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProductoDetalleDTO>> GetProductoDetalle()
        {
            var productos = await _context.Productos
                        .Include(p => p.Marca)
                        .Include(p => p.Talle)
                        .Include(p => p.Genero)
                        .ToListAsync();

            return _mapper.Map<IEnumerable<ProductoDetalleDTO>>(productos);

        }

        public async Task<ProductoDetalleDTO> GetProductoDetalleById(int id)
        {
            var producto = await _context.Productos
            .Include(p => p.Marca)
            .Include(p => p.Talle)
            .Include(p => p.Genero)
            .FirstOrDefaultAsync(p => p.IdProducto == id);

            return _mapper.Map<ProductoDetalleDTO>(producto);

        }
    }
}
