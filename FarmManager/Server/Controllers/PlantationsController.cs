using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FarmManager.Server.Data;
using FarmManager.Shared;
using System.Security.Claims;
using FarmManager.Shared.ViewModels;
using Microsoft.AspNetCore.Authorization;

namespace FarmManager.Server.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    
    public class PlantationsController : ControllerBase
    {
        private readonly FarmManagerContext _context;

        public PlantationsController(FarmManagerContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            List<PlantationViewModel> plantationViewModels = new List<PlantationViewModel>();

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var fields = await _context.Fields.Include(x => x.Plantations).
                Where(x => x.ApplicationUserId == userId).
                ToListAsync();

            foreach (var field in fields)
            {
                if (field.Plantations != null)
                    foreach (var plantation in field.Plantations)
                    {
                        plantation.Plant = _context.Plants.Single(x => x.Id == plantation.PlantId);
                        plantation.Growth = _context.Growths.Single(x => x.Id == plantation.GrowthId);

                        plantationViewModels.Add(new PlantationViewModel() { Plantation = plantation, Field = field });
                    }
            }

            if(plantationViewModels.Count == 0)
                return NotFound();

            return Ok(plantationViewModels);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var plantation = await _context.Plantations.FindAsync(id);

            if (plantation == null)
            {
                return NotFound();
            }

            plantation.Plant = await _context.Plants.FindAsync(plantation.PlantId);
            plantation.Growth = await _context.Growths.FindAsync(plantation.GrowthId);

            var plantationViewModel = new PlantationViewModel()
            {
                Plantation = plantation,
                Field = await _context.Fields.FindAsync(plantation.FieldId)
            };

            return Ok(plantationViewModel);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Plantation plantation)
        {
            if (id != plantation.Id)
            {
                return BadRequest();
            }

            _context.Entry(plantation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PlantationExists(id))
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
        public async Task<IActionResult> Post(Plantation plantation)
        {
            _context.Plantations.Add(plantation);
            await _context.SaveChangesAsync();

            return Ok(plantation);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var plantation = await _context.Plantations.FindAsync(id);
            if (plantation == null)
            {
                return NotFound();
            }

            _context.Plantations.Remove(plantation);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PlantationExists(int id)
        {
            return _context.Plantations.Any(e => e.Id == id);
        }
    }
}
