using System.Security.AccessControl;
using Microsoft.AspNetCore.Mvc;
using Extra.Server.Interfaces.Services;
using System.Threading.Tasks;

namespace Extra.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {   
        private readonly ICharacterService characterService;

        public CharacterController(ICharacterService characterService)
        {
            this.characterService = characterService;
        }
        [HttpGet]

        public async Task<IActionResult> Get()
        {
           var character = await characterService.GetList();

            return Ok(character);
        }
    }
}