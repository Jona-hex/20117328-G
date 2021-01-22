using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DogKeepers.Server.Interfaces.Services;

namespace DogKeepers.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RaceController : ControllerBase
    {

        private readonly IRaceService raceService;

        public RaceController(IRaceService raceService)
        {
            this.raceService = raceService;
        }

        [HttpGet]

        public async Task<IActionResult> Get(){
            var races = await raceService.Get();

            return Ok(races);
        }
    }
}