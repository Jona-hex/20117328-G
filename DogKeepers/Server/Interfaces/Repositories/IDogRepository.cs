using System.Collections.Generic;
using System.Threading.Tasks;
using DogKeepers.Server.Entities;
using DogKeepers.Client.Shared.QueryFilters;
using System;

namespace DogKeepers.Server.Interfaces.Repositories
{
    public interface IDogRepository
    {
        Task<Tuple<int, List<Dog>>> GetList(DogsQueryFilter model);
        Task<Dog> GetById(int id);
    }
}