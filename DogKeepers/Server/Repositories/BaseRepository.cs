 using DogKeepers.Server.Interfaces.Repositories;
 using System.Threading.Tasks;
 using MySql.Data.MySqlClient;
 using Dapper;
 using System.Linq;


namespace DogKeepers.Server.Repositories
{
    public class BaseRepository : IBaseRepository
    {

        public async Task<int> Count(string command)
        {
           var count = 0;

           using(var connection = new MySqlConnection("Server=localhost;Database=DogKeepers;User Id=root"))
           {
               var sqlResponse = 
                await connection.QueryAsync<int>(
                    command
                   
               );

               count = sqlResponse.First();

           }

           return count;
        }
    }
}