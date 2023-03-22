using Microsoft.AspNetCore.Mvc;
using Utevolux.Repository;

namespace Utevolux.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MountsController : ControllerBase
    {
        private readonly IMountRepository _mountRepository;
        public MountsController(IMountRepository mountRepository)
        {
            _mountRepository = mountRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _mountRepository.GetMounts());
        }
    }

    public class Mounts
    {
        public string Name { get; set; }
        public string Img { get; set; }
    }
}