using ExamenParcial2.Server.Services;
using System.Threading.Tasks;
using ExamenParcial2.Server.Entities;
using ExamenParcial2.Server.Interfaces.Repositories;

namespace ExamenParcial2.Server.Services
{
    public class CharacterService : ICharacterService
    {
        private readonly ICharacterRepository characterRepository;

        public CharacterService(ICharacterRepository characterRepository)
        {
            this.characterRepository = characterRepository;
        }
        public async Task<Character> GetList()
        {
            await Task.Delay(2000);

             return new Character()
             {
                 id = 1,
                 name = "walther white",
                 birthday = "09-07-1958",
                 nickname = "Walt"
             };
        }
    }
}