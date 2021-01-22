using System.ComponentModel.Design.Serialization;
using System.Collections.Generic;
using System.Threading.Tasks;
using DogKeepers.Server.Interfaces.Repositories;
using DogKeepers.Server.Interfaces.Services;
using DogKeepers.Server.Entities;

namespace DogKeepers.Server.Interfaces.Services
{
    public class SizeService : ISizeService 
    {
        private readonly ISizeRepository sizeRepository;

        public SizeService(ISizeRepository sizeRepository)
        {
            this.sizeRepository = sizeRepository;
        }
        public async Task<List<Size>> Get()
        {
            var sizes = await sizeRepository.Get();

            return sizes;
        }
    }
}