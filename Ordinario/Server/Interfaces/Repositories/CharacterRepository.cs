using System.Collections.Generic;
using System.Threading.Tasks;
using ExamenParcial2.Server.Entities;
using ExamenParcial2.Server.Interfaces.Repositories;

namespace ExamenParcial2.Server.Interfaces.Repositories
{
    public class CharacterRepository : ICharacterRepository
    {
        public Task<List<Character>> GetList(int random)
        {
            throw new System.NotImplementedException();
        }
    }
}