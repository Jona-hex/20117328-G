 using DogKeepers.Server.Interfaces.Repositories;
 using System.Threading.Tasks;
 using MySql.Data.MySqlClient;
 using Dapper;
 using System.Linq;
using Microsoft.Extensions.Options;
using DogKeepers.Server.Options;

namespace DogKeepers.Server.Repositories
{
    
    public class BaseRepository : IBaseRepository
    {   
        private readonly string connectionString;

        public BaseRepository(IOptions<ConnectionStringsOptions> connectionString)
        {
            this.connectionString = connectionString.Value.Production;
        }

        public async Task<int> Count(string command)
        {
           
           var count = 0;

           using(var connection = new MySqlConnection(connectionString))
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