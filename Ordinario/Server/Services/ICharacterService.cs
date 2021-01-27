using System.Threading.Tasks;
using ExamenParcial2.Server.Entities;

namespace  ExamenParcial2.Server.Services
{
    public interface ICharacterService
    {
        Task<Character> GetList();
    }
}