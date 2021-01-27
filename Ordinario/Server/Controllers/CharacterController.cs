using System;
using Microsoft.AspNetCore.Mvc;
using ExamenParcial2.Server.Services;
using System.Threading.Tasks;

namespace ExamenParcial2.Server.Controllers
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