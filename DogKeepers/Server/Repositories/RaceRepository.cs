using System.Collections.Generic;
using System.Threading.Tasks;
using DogKeepers.Server.Entities;
using DogKeepers.Server.Interfaces.Repositories;
using MySql.Data.MySqlClient;
using Dapper;
using Microsoft.Extensions.Options;
using DogKeepers.Server.Options;

namespace DogKeepers.Server.Repositories
{
    public class RaceRepository : IRaceRepository
    {
        private readonly string connectionString;

        public RaceRepository(IOptions<ConnectionStringsOptions> connectionString)
        {
            
            this.connectionString = connectionString.Value.Production;
        }

        public async Task<List<Race>> Get()
        {
            List<Race> races = new List<Race>();
            var sqlCommand = "select * from races";

            using(var connection = new MySqlConnection(connectionString)){
                var sqlResponse = 
                    await connection.QueryAsync<Race>(
                        sqlCommand
                    );
                    races = sqlResponse.AsList();
            }

            return races;
        }
    }
}