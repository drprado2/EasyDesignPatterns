using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EasyDesignPatterns.API.Controllers
{
    [Route("api/design-patterns")]
    public class DesignPatternsController : Controller
    {
        [HttpGet]
        [Route("abstract-factory")]
        public async Task<IActionResult> GetAbstractFactory()
        {
            var explanations = new[] {"Abstract Factory é um pattern utilizado para b la bnla la", "bla bla bla aasdsad bla"};

            return Ok(explanations);
        }
    }
}