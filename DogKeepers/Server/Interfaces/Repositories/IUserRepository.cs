using DogKeepers.Shared.QueryFilters;
using System.Threading.Tasks;
using DogKeepers.Server.Entities;

namespace DogKeepers.Server.Interfaces.Repositories
{
    public interface IUserRepository
    {
        Task<User> GetByEmailPassword(SignInQueryFilter user);
    }
}