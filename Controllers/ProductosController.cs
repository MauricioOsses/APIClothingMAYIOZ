using APIClothingMAYIOZ.DTO_s;
using APIClothingMAYIOZ.Model;
using APIClothingMAYIOZ.Repositories;
using APIClothingMAYIOZ.Services.ServiceProducto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace APIClothingMAYIOZ.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductosController : Controller
    {
        private readonly IProductoService _service;

        public ProductosController(IProductoService service)
        {
            _service = service;
        }

        [HttpGet("Get")]
        public async Task<ActionResult<IEnumerable<ProductoDetalleDTO>>> Get()
        {
            var productos = await _service.GetProductoDetalle();
            return Ok(productos);
        }

        [HttpGet("GetById/{id}")]
        public async Task<ActionResult<ProductoDetalleDTO>> GetById(int id)
        {
            var producto = await _service.GetProductoDetalleById(id);
            return producto is null ? NotFound() : Ok(producto);

        }

        [HttpPost("Add")]
        public async Task<IActionResult> Post(ProductoDTO productoDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var producto = new Producto
            {
                Nombre = productoDto.Nombre,
                IdMarca = productoDto.IdMarca,
                IdTalle = productoDto.IdTalle,
                IdGenero = productoDto.IdGenero,
                Precio = productoDto.Precio
            };
            await _service.Create(producto);
            return CreatedAtAction(nameof(GetById), new { id = producto.IdProducto }, producto);
        }

        [HttpPut("Update/{id}")]
        public async Task<IActionResult> Put(int id, Producto producto)
        {
            if (id != producto.IdProducto) return BadRequest();
            await _service.Update(producto);
            return NoContent();

        }

        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.Delete(id);
            return NoContent();

        }

    }
}
