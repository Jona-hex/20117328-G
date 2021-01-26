using System.Threading.Tasks;
using DogKeepers.Shared.QueryFilters;
using Microsoft.AspNetCore.Components;
using Radzen;

namespace DogKeepers.Client.Components.Signin
{
    public partial class SignInDialog{

        [Inject] private DialogService dialogService {get; set;}

        private SignInQueryFilter user = new SignInQueryFilter();
        private bool isLoading = false;

        private async Task SignIn(){
            await Task.Delay(300);
            System.Console.WriteLine(user.Email);
            System.Console.WriteLine(user.Password);
        }
    }
}