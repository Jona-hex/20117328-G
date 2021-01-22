using System.Threading.Tasks;
using DogKeepers.Server.Entities;
using System.Collections.Generic;
using DogKeepers.Server.Utils;
using DogKeepers.Client.Shared.QueryFilters;

namespace DogKeepers.Server.Interfaces.Services
{
    public interface IDogService
    {
        Task<PagedList<Dog>> GetList(DogsQueryFilter model);
    }
}