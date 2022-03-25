using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FarmManager.Server.Data;

namespace FarmManager.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SpeciesController : ControllerBase
    {
        private readonly FarmManagerContext _context;

        public SpeciesController(FarmManagerContext context)
        {
            _context = context;
        }
        
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var species = await _context.Species.Include(s => s.Breeds).ToListAsync();
            return Ok(species);
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var species = await _context.Species.FindAsync(id);

            if (species == null)
            {
                return NotFound();
            }

            return Ok(species);
        }        
    }
}
