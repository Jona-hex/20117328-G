using System.Net.Http;
using System.Collections.Generic;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;
using  Extra.Shared.DTOs;

namespace  Extra.Client.Pages
{
    public partial class Index
    {
        [Inject] private HttpClient httpClient {get; set;}

        private List<CharacterDto> CharacterList { get; set; } = null;

        protected override async Task OnInitializedAsync()
        {
            await LoadSuggestions();
        }
        private async Task LoadSuggestions()
        {
            CharacterList =
                await httpClient.GetFromJsonAsync<List<CharacterDto>>("https://www.breakingbadapi.com/api/characters/1");
       }
    }
}