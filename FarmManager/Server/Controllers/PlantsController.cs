using FarmManager.Server.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FarmManager.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PlantsController : ControllerBase
    {
        private readonly FarmManagerContext _context;

        public PlantsController(FarmManagerContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var plants = await _context.Plants.ToListAsync();

            return Ok(plants);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var plant = await _context.Plants.FindAsync(id);

            if (plant == null)
            {
                return NotFound();
            }

            return Ok(plant);
        }
    }
}
