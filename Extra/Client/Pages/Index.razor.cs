using System.Net.Http;
using System.Collections.Generic;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;
using  Extra.Shared.DTOs;
using Extra.Shared;
namespace  Extra.Client.Pages
{
    public partial class Index
    {
        string conditions;
        [Inject] private HttpClient httpClient {get; set;}

        private List<CharacterDto> CharacterList { get; set; } = null;

        protected override async Task OnInitializedAsync()
        {
            await LoadCharacters();
        }
        private async Task LoadCharacters()
        {
            CharacterList =
                await httpClient.GetFromJsonAsync<List<CharacterDto>>($"https://www.breakingbadapi.com/api/characters?name={FiltersName}");
       }
       private async Task OnSearch()
       {
            await LoadCharacters();
       }

    }
}