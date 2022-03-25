using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FarmManager.Server.Data;
using FarmManager.Shared;
using System.Security.Claims;

namespace FarmManager.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AnimalsCalculatorResultsController : ControllerBase
    {
        private readonly FarmManagerContext _context;

        public AnimalsCalculatorResultsController(FarmManagerContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAnimalsCalculatorResults()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var result =  await _context.AnimalsCalculatorResults.Where(x => x.ApplicationUserId == userId).ToListAsync();

            return Ok(result);
        }       

        [HttpPost]
        public async Task<IActionResult> PostAnimalsCalculatorResult(AnimalsCalculatorResult animalsCalculatorResult)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (userId == null)
                return Unauthorized();

            animalsCalculatorResult.ApplicationUserId = userId;

            _context.AnimalsCalculatorResults.Add(animalsCalculatorResult);
            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAnimalsCalculatorResult(int id)
        {
            var animalsCalculatorResult = await _context.AnimalsCalculatorResults.FindAsync(id);
            if (animalsCalculatorResult == null)
            {
                return NotFound();
            }

            _context.AnimalsCalculatorResults.Remove(animalsCalculatorResult);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
