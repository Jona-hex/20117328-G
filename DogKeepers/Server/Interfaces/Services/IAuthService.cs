using System.Threading.Tasks;
using DogKeepers.Shared.QueryFilters;
using DogKeepers.Server.Entities;

namespace DogKeepers.Server.Interfaces.Services
{
    public interface IAuthService
    {
        Task<Jwt> Authenticate(SignInQueryFilter user);
    }
}