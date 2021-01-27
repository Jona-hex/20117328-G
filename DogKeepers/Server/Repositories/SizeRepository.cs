using System.Collections.Generic;
using System.Threading.Tasks;
using Dapper;
using DogKeepers.Server.Entities;
using DogKeepers.Server.Interfaces.Repositories;
using DogKeepers.Server.Options;
using Microsoft.Extensions.Options;
using MySql.Data.MySqlClient;

namespace DogKeepers.Server.Repositories
{
    public class SizeRepository : ISizeRepository
    {
        private readonly string connectionString;

        public SizeRepository(IOptions<ConnectionStringsOptions> connectionString)
        {
            this.connectionString = connectionString.Value.Production;
        }

        public async Task<List<Size>> Get(){
            
            List<Size> sizes = new List<Size>();
            var sqlCommand = "select * from sizes";

             using(var connection = new MySqlConnection(connectionString))
           {    

               var sqlResponse = await connection.QueryAsync<Size>(
                   sqlCommand
               );
               
               sizes = sqlResponse.AsList();

           }
            return sizes;
        }
    }
}