using FarmManager.Server.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FarmManager.Server.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class GrowthsController : Controller
    {
        private readonly FarmManagerContext _context;

        public GrowthsController(FarmManagerContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var growths = await _context.Growths.ToListAsync();

            return Ok(growths);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var growth = await _context.Growths.FindAsync(id);

            if (growth == null)
            {
                return NotFound();
            }

            return Ok(growth);
        }
    }
}
