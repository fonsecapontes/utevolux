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
                new Creatures() {Name = "Acid blob 1", Img = "https://www.tibiawiki.com.br/images/e/e9/Filth_Toad.gif"},
                new Creatures() {Name = "Acid blob 2", Img = "https://www.tibiawiki.com.br/images/e/e9/Filth_Toad.gif"},
                new Creatures() {Name = "Acid blob 3", Img = "https://www.tibiawiki.com.br/images/e/e9/Filth_Toad.gif"}
            };

            return Ok(res);
        }

        [HttpGet]
        [Route("bosses")]
        public async Task<IActionResult> GetBosses()
        {
            var res = new List<Creatures>()
            {
                new Creatures() {Name = "Boss 1", Img = "https://www.tibiawiki.com.br/images/e/e9/Filth_Toad.gif"},
                new Creatures() {Name = "Boss 2", Img = "https://www.tibiawiki.com.br/images/e/e9/Filth_Toad.gif"},
                new Creatures() {Name = "Boss 3", Img = "https://www.tibiawiki.com.br/images/e/e9/Filth_Toad.gif"}
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