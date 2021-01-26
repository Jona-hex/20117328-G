using System.Globalization;
using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using DogKeepers.Server.Interfaces.Services;
using DogKeepers.Shared.QueryFilters;

namespace DogKeepers.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class AuthController : ControllerBase
    {   

        private readonly IAuthService authService;

        public AuthController(IAuthService authService)
        {
            this.authService = authService;
        }

        [HttpPost]

        public async Task<IActionResult> Post(SignInQueryFilter model)
        {
            var response = await authService.Authenticate(model);
            return Ok("");
        }
    }
}