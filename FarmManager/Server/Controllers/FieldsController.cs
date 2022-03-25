using FarmManager.Server.Data;
using FarmManager.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace FarmManager.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class FieldsController : ControllerBase
    {
        private readonly FarmManagerContext _context;

        public FieldsController(HttpClient client, FarmManagerContext context)
        {            
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var fields = await _context.Fields.Include(x => x.Plantations).
                Where(x => x.ApplicationUserId == userId).ToListAsync();
            return Ok(fields);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var field = await _context.Fields.SingleOrDefaultAsync(a => a.Id == id);

            if (field == null)
            {
                return NotFound();
            }

            var plantations = _context.Plantations.Include(x => x.Growth).
                            Include(x => x.Plant).
                            Where(x => x.FieldId == field.Id);

            field.Plantations = await plantations.ToListAsync();

            return Ok(field);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Field field)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (userId == null)
                return Unauthorized();

            field.ApplicationUserId = userId;

            _context.Fields.Add(field);
            await _context.SaveChangesAsync();
            
            return Ok(field);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Field field)
        {
            if (id != field.Id)
            {
                return BadRequest();
            }

            _context.Entry(field).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FieldExist(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var field = await _context.Fields.FindAsync(id);
            if (field == null)
            {
                return NotFound();
            }

            _context.Fields.Remove(field);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FieldExist(int id)
        {
            return _context.Animals.Any(e => e.Id == id);
        }
    }
}
