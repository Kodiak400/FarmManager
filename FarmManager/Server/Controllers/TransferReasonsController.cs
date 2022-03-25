using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FarmManager.Server.Data;

namespace FarmManager.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TransferReasonsController : ControllerBase
    {
        private readonly FarmManagerContext _context;

        public TransferReasonsController(FarmManagerContext context)
        {
            _context = context;
        }
        
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var transferReasons =  await _context.TransferReasons.ToListAsync();
            
            return Ok(transferReasons);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var transferReason = await _context.TransferReasons.FindAsync(id);

            if (transferReason == null)
            {
                return NotFound();
            }

            return Ok(transferReason);
        }        
    }
}
