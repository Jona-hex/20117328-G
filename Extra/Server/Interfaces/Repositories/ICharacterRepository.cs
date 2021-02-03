using System.Threading.Tasks;
using System.Collections.Generic;
using Extra.Server.Entities;

namespace Extra.Server.Interfaces.Repositories
{
    public interface ICharacterRepository
    {
        Task<List<Character>> GetList(int random);
    }
}