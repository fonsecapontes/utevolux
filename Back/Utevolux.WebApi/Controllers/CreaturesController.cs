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
            return Ok(await _creatureRepository.GetCreatures());
        }

        [HttpGet]
        [Route("bosses")]
        public async Task<IActionResult> GetBosses()
        {
            return Ok(await _creatureRepository.GetBosses());
        }
    }
}