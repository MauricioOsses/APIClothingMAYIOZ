using APIClothingMAYIOZ.Data;
using APIClothingMAYIOZ.DTO_s;
using APIClothingMAYIOZ.Model;
using Microsoft.EntityFrameworkCore;

namespace APIClothingMAYIOZ.Repositories.ProductoRepository
{
    public class ProductoRepository : RepositoryBase<Producto>, IProductoRepository
    {
        public ProductoRepository(ClothingDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<ProductoDetalleDTO>> GetProductoDetalle()
        {
            return await _context.Productos
                        .Include(p => p.Marca)
                        .Include(p => p.Talle)
                        .Include(p => p.Genero)
                        .Select(p => new ProductoDetalleDTO
                        {
                            IdProducto = p.IdProducto,
                            Nombre = p.Nombre!,
                            Marca = p.Marca!.NombreMarca,
                            Talle = p.Talle!.NombreTalle,
                            Genero = p.Genero!.NombreGenero,
                            Precio = p.Precio
                        })
                        .ToListAsync();
        }

        public async Task<ProductoDetalleDTO> GetProductoDetalleById(int id)
        {
            return await _context.Productos
                        .Include(p => p.Marca)
                        .Include(p => p.Talle)
                        .Include(p => p.Genero)
                        .Where(p => p.IdProducto == id)
                        .Select(p => new ProductoDetalleDTO
                        {
                            IdProducto = p.IdProducto,
                            Nombre = p.Nombre!,
                            Marca = p.Marca!.NombreMarca,
                            Talle = p.Talle!.NombreTalle,
                            Genero = p.Genero!.NombreGenero,
                            Precio = p.Precio
                        })
                        .FirstOrDefaultAsync();
        }
    }
}
