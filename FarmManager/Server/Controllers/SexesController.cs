using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FarmManager.Server.Data;

namespace FarmManager.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SexesController : ControllerBase
    {
        private readonly FarmManagerContext _context;

        public SexesController(FarmManagerContext context)
        {
            _context = context;
        }
        
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var sexes = await _context.Sexes.ToListAsync();

            return Ok(sexes);
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var sex = await _context.Sexes.FindAsync(id);

            if (sex == null)
            {
                return NotFound();
            }

            return Ok(sex);
        }
    }
}
