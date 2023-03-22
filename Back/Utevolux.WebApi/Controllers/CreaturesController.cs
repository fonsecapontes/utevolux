using Microsoft.AspNetCore.Mvc;

namespace Utevolux.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CreaturesController : ControllerBase
    {
        public CreaturesController()
        {
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var res = new List<Creatures>()
            {
                new Creatures() {Name = "Acid blob", Img = "https://www.tibiawiki.com.br/images/e/e9/Filth_Toad.gif"},
                new Creatures() {Name = "Acid blob", Img = "https://www.tibiawiki.com.br/images/e/e9/Filth_Toad.gif"},
                new Creatures() {Name = "Acid blob", Img = "https://www.tibiawiki.com.br/images/e/e9/Filth_Toad.gif"}
            };

            return Ok(res);
        }
    }

    public class Creatures
    {
        public string Name { get; set; }
        public string Img { get; set; }
    }
}