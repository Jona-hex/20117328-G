using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using DogKeepers.Client.Interfaces;
using DogKeepers.Shared.ApiResponses;
using DogKeepers.Shared.DTOs;
using DogKeepers.Shared.QueryFilters;
using Microsoft.AspNetCore.Components;
using Radzen;

namespace DogKeepers.Client.Components.Signin
{
    public partial class SignInDialog{

        [Inject] private DialogService dialogService {get; set;}
        [Inject] private HttpClient httpClient{get; set;}
        [Inject] private IJwtProvider jwtProvider{get; set;}

        private string errorMessage;
        private bool isLoading = false;

        private SignInQueryFilter user = new SignInQueryFilter();
        private async Task SignIn(){
            isLoading = true;
            errorMessage = "";

            var apiResponse =
                await httpClient.PostAsJsonAsync("api/auth",user);

            var response = await apiResponse.Content.ReadFromJsonAsync<ApiResponse<JwtDto>>();

            if(response.Errors != null)
            {
                errorMessage = response.Errors.First().Detail;
            }else 
            {
                await jwtProvider.Login(response.Data);

                dialogService.Close(true);
            }

            isLoading = false;
        }
    }
}