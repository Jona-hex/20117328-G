using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using DogKeepers.Server.Interfaces.Services;

namespace DogKeepers.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class SizeController : ControllerBase
    {   
        private readonly ISizeService sizeService;

        public SizeController(ISizeService sizeService)
        {
            this.sizeService = sizeService;
        }

        [HttpGet] 
        public async Task<IActionResult> Get()
        {
             var sizes = await sizeService.Get();

             return Ok(sizes);
        }
    }
}