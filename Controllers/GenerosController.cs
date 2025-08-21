using APIClothingMAYIOZ.Model;
using APIClothingMAYIOZ.Services.ServiceGenero;
using Microsoft.AspNetCore.Mvc;

namespace APIClothingMAYIOZ.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GenerosController : Controller
    {
        private readonly IGeneroService _service;

        public GenerosController(IGeneroService service)
        {
            _service = service;
        }

        [HttpGet("Get")]
        public async Task<ActionResult<IEnumerable<Genero>>> Get()
        {
            var generos = await _service.GetAll();
            return Ok(generos);
        }

        [HttpGet("GetById{id}")]
        public async Task<ActionResult<Genero>> GetById(int id)
        {
            var genero = await _service.GetById(id);
            return genero is null ? NotFound() : Ok(genero);

        }

        [HttpPost("Add")]
        public async Task<IActionResult> Post(Genero genero)
        {
            await _service.Create(genero);
            return CreatedAtAction(nameof(GetById), new { id = genero.IdGenero }, genero);
        }

        [HttpPut("Update/{id}")]
        public async Task<IActionResult> Put(int id, Genero genero)
        {
            if (id != genero.IdGenero) return BadRequest();
            await _service.Update(genero);
            return NoContent();

        }

        [HttpDelete("Delete{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.Delete(id);
            return NoContent();

        }
    }
}
