using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FarmManager.Server.Data;
using FarmManager.Shared;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace FarmManager.Server.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]    
    public class AnimalsController : ControllerBase
    {
        private readonly FarmManagerContext _context;

        public AnimalsController(FarmManagerContext context)
        {
            _context = context;
        }
        
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var animals = await _context.Animals.Include(a => a.Species)
                .Include(a => a.Sex)
                .Include(a => a.IncomeReason)
                .Include(a => a.Breed)
                .Where(a => a.ApplicationUserId == userId)
                .ToListAsync();
            return Ok(animals);
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var animal = await _context.Animals.SingleOrDefaultAsync(a => a.Id == id);

            if (animal == null)
            {
                return NotFound();
            }

            animal.Species = await _context.Species.SingleOrDefaultAsync(s => s.Id == animal.SpeciesId);
            animal.Sex = await _context.Sexes.SingleOrDefaultAsync(s => s.Id == animal.SexId);
            animal.Breed = await _context.Breeds.SingleOrDefaultAsync(b => b.Id == animal.BreedId);
            animal.IncomeReason = await _context.TransferReasons.SingleOrDefaultAsync(t => t.Id == animal.IncomeReasonId);
            animal.OutcomeReason = await _context.TransferReasons.SingleOrDefaultAsync(t => t.Id == animal.OutcomeReasonId);           

            return Ok(animal);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Animal animal)
        {
            if (id != animal.Id)
            {
                return BadRequest();
            }

            _context.Entry(animal).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AnimalExists(id))
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

        [HttpPost]
        public async Task<IActionResult> Post(Animal animal)
        {            
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (userId == null)
                return Unauthorized();

            animal.ApplicationUserId = userId;
            
            _context.Animals.Add(animal);
            await _context.SaveChangesAsync();

            return Ok(animal);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var animal = await _context.Animals.FindAsync(id);
            if (animal == null)
            {
                return NotFound();
            }

            _context.Animals.Remove(animal);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AnimalExists(int id)
        {
            return _context.Animals.Any(e => e.Id == id);
        }
    }
}
