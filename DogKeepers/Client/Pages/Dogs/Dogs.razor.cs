using System.Runtime.InteropServices;
using System.Linq.Expressions;
using System.IO;
using System;
using System.Security.AccessControl;
using System.Net.Http.Headers;
using System.Net;
using DogKeepers.Shared.DTOs;
using System.Net.Http;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;
using DogKeepers.Shared.Metadata;
using DogKeepers.Shared.ApiResponses;
using DogKeepers.Client.Shared.QueryFilters;

namespace DogKeepers.Client.Pages.Dogs
{
    public partial class Dogs
    {
            private int TotalDogs = 0;

            [Inject] public HttpClient httpClient { get; set; }

            private List<DogDto> DogsList = null;

            private bool IsLoadingDogsList = true;

            private List<SizeDto> sizes = new List<SizeDto>();

            private List<RaceDto> Races = new List<RaceDto>();

            private PaginationMetadata PaginationData;

            private DogsQueryFilter Filters = new DogsQueryFilter();



            protected override async Task OnInitializedAsync()
            {
                await LoadDogs();
                await LoadSizes();
                await LoadRaces();
            }
            private async Task LoadDogs(bool search = false){
                DogsList = null;
                IsLoadingDogsList = true;

                
                Filters.PageNumberForce = 
                    PaginationData == null || search 
                        ?   1
                        :   Filters.PageNumber;

                var filterString = $"?PageNumber={Filters.PageNumber}&pageSize=8&Name={Filters.Name}&SizeId={Filters.SizeId}&RaceId={Filters.RaceId}"; 

                var response = await httpClient.GetFromJsonAsync<ApiResponse<List<DogDto>>>("/api/dog/getlist{filterString}");

                DogsList = response.Data;
                PaginationData = response.Pagination;
                TotalDogs = response.Pagination.TotalCount;

                IsLoadingDogsList = false;
            }

            private async Task LoadSizes(){
                sizes =
                    await httpClient.GetFromJsonAsync<List<SizeDto>>("/api/size");
            }

            private async Task LoadRaces(){
                Races = 
                    await httpClient.GetFromJsonAsync<List<RaceDto>>("/api/race");
            }

            private async Task OnSelectedPage(int pageNumberClicked)
            {
                Filters.PageNumberForce = pageNumberClicked;

                await LoadDogs();
            }
        private async Task OnSearch(){
            await LoadDogs(true);
        }
    }
}