using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models.HomeViewModels
{
    public class LoginViewModel
    {
        [Display(Name ="Email", ResourceType = typeof(WebApplication1.Common))]
        [Required(ErrorMessage = "EmailRequired")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "PasswordRequired")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
