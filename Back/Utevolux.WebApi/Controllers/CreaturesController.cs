using Microsoft.AspNetCore.Mvc;
using Utevolux.Repository;

namespace Utevolux.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CreaturesController : ControllerBase
    {
        private readonly ICreatureRepository _creatureRepository;

        public CreaturesController(ICreatureRepository creatureRepository)
        {
            _creatureRepository = creatureRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            //var res = new List<CreatureEntity>()
            //{
            //    new CreatureEntity() {Name = "Acid blob 1", Image = "https://www.tibiawiki.com.br/images/e/e9/Filth_Toad.gif"},
            //    new CreatureEntity() {Name = "Acid blob 2", Image = "https://www.tibiawiki.com.br/images/e/e9/Filth_Toad.gif"},
            //    new CreatureEntity() {Name = "Acid blob 3", Image = "https://www.tibiawiki.com.br/images/e/e9/Filth_Toad.gif"}
            //};

            return Ok(await _creatureRepository.GetCreatures());
        }

        [HttpGet]
        [Route("bosses")]
        public async Task<IActionResult> GetBosses()
        {
            //var res = new List<CreatureEntity>()
            //{
            //    new CreatureEntity() {Name = "Boss 1", Image = "https://www.tibiawiki.com.br/images/e/e9/Filth_Toad.gif"},
            //    new CreatureEntity() {Name = "Boss 2", Image = "https://www.tibiawiki.com.br/images/e/e9/Filth_Toad.gif"},
            //    new CreatureEntity() {Name = "Boss 3", Image = "https://www.tibiawiki.com.br/images/e/e9/Filth_Toad.gif"}
            //};

            return Ok(await _creatureRepository.GetCreatures());
        }
    }
}