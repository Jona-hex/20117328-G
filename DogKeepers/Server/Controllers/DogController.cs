using Microsoft.AspNetCore.Mvc;
using DogKeepers.Server.Interfaces.Services;
using System.Threading.Tasks;
using DogKeepers.Client.Shared.QueryFilters;
using DogKeepers.Shared.ApiResponses;
using DogKeepers.Shared.Metadata;
using System.Collections.Generic;
using DogKeepers.Server.Entities;

namespace DogKeepers.Server.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class DogController : ControllerBase
    {
        private readonly IDogService dogService;
        public DogController(IDogService dogService)
        {
            this.dogService = dogService;
        }
        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] DogsQueryFilter model)
        {
            var dogs = await  dogService.GetList(model);
            
            var apiResponse = new ApiResponse<List<Dog>>(
                dogs,
                new PaginationMetadata(){
                    CurrentPage = dogs.CurrentPage,
                    PageSize = dogs.PageSize,
                    TotalCount = dogs.TotalCount,
                    TotalPages = dogs.TotalPages,
                    HasNextPage = dogs.HasNextPage,
                    HasPreviousPage = dogs.HasPreviousPage,
                    NextPageNumber = dogs.NextPageNumber,
                    PreviousPageNumber = dogs.PreviousPageNumber
                }
            );

            return Ok(apiResponse);
        }
        
        [HttpGet("GetById")]

        public async Task<IActionResult> GetById(int id){

            var response = await dogService.GetById(id);

            return Ok(response);
        }

    }
}