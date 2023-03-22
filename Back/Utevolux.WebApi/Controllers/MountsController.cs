using Microsoft.AspNetCore.Mvc;

namespace Utevolux.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MountsController : ControllerBase
    {
        public MountsController()
        {
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var res = new List<Mounts>()
            {
                new Mounts() {Name = "Mount 1", Img = "https://www.tibiawiki.com.br/images/e/e9/Filth_Toad.gif"},
                new Mounts() {Name = "Mount 2", Img = "https://www.tibiawiki.com.br/images/e/e9/Filth_Toad.gif"},
                new Mounts() {Name = "Mount 3", Img = "https://www.tibiawiki.com.br/images/e/e9/Filth_Toad.gif"}
            };

            return Ok(res);
        }
    }

    public class Mounts
    {
        public string Name { get; set; }
        public string Img { get; set; }
    }
}