using Extra.Server.Interfaces.Services;
using System.Threading.Tasks;
using Extra.Server.Entities;
using Extra.Server.Interfaces.Repositories;
using System.Collections.Generic;

namespace DogKeepers.Server.Services
{
    public class CharacterService : ICharacterService
    {
        private readonly ICharacterRepository characterRepository;

        public CharacterService(ICharacterRepository characterRepository)
        {
            this.characterRepository = characterRepository;
        }
        public async Task<List<Character>> GetList()
        { 
           var characters = await characterRepository.GetList(1);

           return characters;
        }
    }
}