using System.ComponentModel.DataAnnotations;

namespace DogKeepers.Shared.QueryFilters
{
    public class SignInQueryFilter
    {   
        [Required]
        [EmailAddress]

        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}