using APIClothingMAYIOZ.Model;
using APIClothingMAYIOZ.Services.ServiceTalle;
using Microsoft.AspNetCore.Mvc;

namespace APIClothingMAYIOZ.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TallesController : Controller
    {
        private readonly ITalleService _service;

        public TallesController(ITalleService service)
        {
            _service = service;
        }

        [HttpGet("Get")]
        public async Task<ActionResult<IEnumerable<Talle>>> Get()
        {
            var talles = await _service.GetAll();
            return Ok(talles);
        }

        [HttpGet("GetById/{id}")]
        public async Task<ActionResult<Talle>> GetById(int id)
        {
            var talle = await _service.GetById(id);
            return talle is null ? NotFound() : Ok(talle);

        }

        [HttpPost("Add")]
        public async Task<IActionResult> Post(Talle talle)
        {
            await _service.Create(talle);
            return CreatedAtAction(nameof(GetById), new { id = talle.IdTalle }, talle);
        }

        [HttpPut("Update/{id}")]
        public async Task<IActionResult> Put(int id, Talle talle)
        {
            if (id != talle.IdTalle) return BadRequest();
            await _service.Update(talle);
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
