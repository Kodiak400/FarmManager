using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FarmManager.Server.Data;

namespace FarmManager.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BreedsController : ControllerBase
    {
        private readonly FarmManagerContext _context;

        public BreedsController(FarmManagerContext context)
        {
            _context = context;
        }
        
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var breeds = await _context.Breeds.ToListAsync();

            return Ok(breeds);
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var breed = await _context.Breeds.FindAsync(id);

            if (breed == null)
            {
                return NotFound();
            }

            return Ok(breed);
        }        
    }
}
