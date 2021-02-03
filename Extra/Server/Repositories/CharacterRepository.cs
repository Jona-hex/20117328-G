using Extra.Server.Interfaces.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;
using Extra.Server.Entities;
using MySql.Data.MySqlClient;
using Dapper;

namespace Extra.Server.Repositories
{
    public class CharacterRepository : ICharacterRepository
    {
        public async Task<List<Character>> GetList(int random)
        {
            List<Character> characters = new List<Character>();

            using(var connection = new MySqlConnection("breakingbadapi.com/documentation/api/characters?name={Walter}")){
                var sqlResponse =
                    await connection.QueryAsync<Character>(
                        "select * from characters"
                    );
                    characters = sqlResponse.AsList();
            }
            return characters;
        }
    }
}