using System.Threading.Tasks;
using Extra.Server.Entities;
using System.Collections.Generic;

namespace Extra.Server.Interfaces.Services
{
    public interface ICharacterService  
    {
        Task<List<Character>> GetList();
    }
}