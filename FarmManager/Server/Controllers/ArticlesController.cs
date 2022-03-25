using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FarmManager.Server.Data;
using FarmManager.Shared;

namespace FarmManager.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ArticlesController : ControllerBase
    {
        private readonly FarmManagerContext _context;

        public ArticlesController(FarmManagerContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Article>>> Get()
        {
            return await _context.Articles.Include(x => x.Paragraphs).ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Article>> Get(int id)
        {
            var article = await _context.Articles.Include(x => x.Paragraphs).SingleAsync(x => x.Id == id);

            if (article == null)
            {
                return NotFound();
            }

            return article;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Article article)
        {
            if (id != article.Id)
            {
                return BadRequest();
            }

            _context.Entry(article).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ArticleExists(id))
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
        public async Task<ActionResult<Article>> Post(Article article)
        {
            _context.Articles.Add(article);
            await _context.SaveChangesAsync();

            return Ok(article);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var article = await _context.Articles.FindAsync(id);
            if (article == null)
            {
                return NotFound();
            }

            _context.Articles.Remove(article);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ArticleExists(int id)
        {
            return _context.Articles.Any(e => e.Id == id);
        }
    }
}
