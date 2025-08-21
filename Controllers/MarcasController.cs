using APIClothingMAYIOZ.Model;
using APIClothingMAYIOZ.Services.ServiceMarca;
using Microsoft.AspNetCore.Mvc;

namespace APIClothingMAYIOZ.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MarcasController : Controller
    {
        private readonly IMarcaService _service;

        public MarcasController(IMarcaService service)
        {
            _service = service;
        }

        [HttpGet("Get")]
        public async Task<ActionResult<IEnumerable<Marca>>> Get()
        {
            var marcas = await _service.GetAll();
            return Ok(marcas);
        }

        [HttpGet("GetById/{id}")]
        public async Task<ActionResult<Marca>> GetById(int id)
        {
            var marca = await _service.GetById(id);
            return marca is null ? NotFound() : Ok(marca);

        }

        [HttpPost("Add")]
        public async Task<IActionResult> Post(Marca marca)
        {
            await _service.Create(marca);
            return CreatedAtAction(nameof(GetById), new { id = marca.IdMarca }, marca);
        }

        [HttpPut("Update/{id}")]
        public async Task<IActionResult> Put(int id, Marca marca)
        {
            if (id != marca.IdMarca) return BadRequest();
            await _service.Update(marca);
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
