using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FarmManager.Server.Data;
using FarmManager.Shared;
using System.Security.Claims;

namespace FarmManager.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CropsCalculatorResultsController : ControllerBase
    {
        private readonly FarmManagerContext _context;

        public CropsCalculatorResultsController(FarmManagerContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetCropsCalculatorResults()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var result = await _context.CropsCalculatorResults.Where(x => x.ApplicationUserId == userId).ToListAsync();
            
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> PostCropsCalculatorResult(CropsCalculatorResult cropsCalculatorResult)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (userId == null)
                return Unauthorized();

            cropsCalculatorResult.ApplicationUserId = userId;

            _context.CropsCalculatorResults.Add(cropsCalculatorResult);
            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCropsCalculatorResult(int id)
        {
            var cropsCalculatorResult = await _context.CropsCalculatorResults.FindAsync(id);
            if (cropsCalculatorResult == null)
            {
                return NotFound();
            }

            _context.CropsCalculatorResults.Remove(cropsCalculatorResult);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
