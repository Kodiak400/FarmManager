using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;

namespace FarmManager.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CropsPurhchasesController : ControllerBase
    {
        private readonly HttpClient _client;

        public CropsPurhchasesController(HttpClient client)
        {
            _client = client;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var html = await _client.GetStringAsync("https://www.farmer.pl/agroskop/zboza/");
            string response = FormatHtml(html);

            return Ok(response);
        }

        private string FormatHtml(string html)
        {
            var regex = new Regex("<table class=\"notowania scrollable locked\">(.|\n)*?</table>");
            var table = regex.Match(html).Value;
            var response = "<p>Prezentowane ceny zł netto/tonę</p>" + table.Replace("notowania scrollable locked", "table table-hover").
                Replace("class=\"skupy\"", "").
                Replace("class=\"head\"", "").
                Replace("prezentowane ceny zł netto/tonę", "") +
                "<p>źródło tabeli z cenami: https://www.farmer.pl/agroskop/zboza/</p>";
            return response;
        }
    }
}
