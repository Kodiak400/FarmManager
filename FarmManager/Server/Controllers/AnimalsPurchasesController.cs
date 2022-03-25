using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;

namespace FarmManager.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AnimalsPurchasesController : ControllerBase
    {
        private readonly HttpClient _client;

        public AnimalsPurchasesController(HttpClient client)
        {
            _client = client;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var html = await _client.GetStringAsync("https://www.cenyrolnicze.pl/bydlo/byki-jalowki-krowy");

            string table = GetTableFromHtml(html);

            var response = FormatAnimalsTable(table);

            return Ok(response);
        }

        private string GetTableFromHtml(string html)
        {
            var regex = new Regex("<table(.|\n)*?</table>");

            var match = regex.Match(html);

            return match.Value;
        }

        private string FormatAnimalsTable(string html)
        {
            string formatted = html;
            var regex = new Regex("<img(.|\n)*?</noscript>");

            while (regex.IsMatch(formatted))
            {
                var match = regex.Match(formatted);

                formatted = formatted.Remove(match.Index, match.Length);
            }

            formatted = formatted.Replace("class=\"table table-bordered top10\"", "class=\"table table - bordered top10\" style=\"font - size: 11px\"");

            return formatted;
        }
    }
}
