using DogKeepers.Server.Interfaces.Repositories;
using System.Threading.Tasks;
using DogKeepers.Server.Entities;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using Dapper;
using Microsoft.Extensions.Options;
using DogKeepers.Server.Options;
using System.Linq;
using System;
using DogKeepers.Client.Shared.QueryFilters;

namespace DogKeepers.Server.Repositories
{
    public class DogRepository : IDogRepository
    {
        private readonly IBaseRepository baseRepository;
        private readonly string connectionString;

        public DogRepository(IBaseRepository baseRepository, IOptions<ConnectionStringsOptions> connectionString)
        {
            this.baseRepository = baseRepository;
            this.connectionString = connectionString.Value.Production;
        }

        public async Task<Tuple<int, List<Dog>>> GetList(DogsQueryFilter model)
        {
            List<Dog> dogs = new List<Dog>();
            string order = "";
            string limit = "";
            string conditions= "";
            string fromTable =@"
                from 
                    dogs 
                    join races
                        on races.Id = raceId
                    join sizes
                        on sizes.Id = sizeId
            ";

            if (model.Random != 0){
                limit = $" limit {model.Random}";
                order = " order by rand()";           
            }else{

                order = "order by dogs.id";
                conditions += !String.IsNullOrEmpty(model.Name) ? $"and dogs.name like '%{model.Name}%'" : "";
                conditions += model.RaceId != 0 ? $" and raceId = {model.RaceId}" : "";
                conditions += model.SizeId != 0 ? $" and sizeId = {model.SizeId}" : "";

                conditions = conditions != "" ? $"where {conditions.Substring(4)}" : "";

                

                var skipDogUntilItem = (model.PageNumber - 1) * model.PageSize;
                limit = $"limit {skipDogUntilItem}, {model.PageSize}";
            }

            var sqlCommand = $@"
                select
                    *
                {fromTable} 
                {conditions}
                {order}
                {limit}
             ";

            var sqlCountCommand = $@"
                select 
                    count(*) 
                {fromTable}
                {conditions}
            ";

            var count = await baseRepository.Count(sqlCountCommand);
            if(count > 0)
           using(var connection = new MySqlConnection(connectionString))
           {
               var sqlResponse = 
                 await connection.QueryAsync<Dog, Race, Size, Dog>(
                   sqlCommand,
                   (dg, ra, si) => 
                   {
                       dg.Race = ra;
                       dg.Size = si;
                       
                       return dg;
                   },
                   splitOn: "id, id"
               );
               
               dogs = sqlResponse.AsList();

           }
           return new Tuple<int, List<Dog>>(count, dogs);
        }
        public async Task<Dog> GetById(int id){
            Dog dog = null;
            var sqlCommand = $@"
            select 
                *
            from 
                    dogs 
                    join races
                        on races.Id = raceId
                    join sizes
                        on sizes.Id = sizeId
                where 
                    dogs.id = {id}
            ";

            using(var connection = new MySqlConnection(connectionString))
            {
                var sqlResponse =
                    await connection.QueryAsync<Dog, Race, Size, Dog>(
                        sqlCommand,
                        (dg, ra, si) => {
                            dg.Race = ra;
                            dg.Size = si;
                            
                            return dg;
                        },
                        splitOn: "id, id"
                    );

                    dog = sqlResponse.FirstOrDefault();
            }
            return dog;
        }
    }
}