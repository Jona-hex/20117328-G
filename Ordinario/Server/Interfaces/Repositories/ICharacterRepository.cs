using System.Threading.Tasks;
using System.Collections.Generic;
using ExamenParcial2.Server.Entities;

namespace ExamenParcial2.Server.Interfaces.Repositories
{
    public interface ICharacterRepository
    {
        Task<List<Character>> GetList(int random);
    }
}