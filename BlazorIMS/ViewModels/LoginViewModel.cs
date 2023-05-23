using System.ComponentModel.DataAnnotations;

namespace BlazorIMS.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        [Required]
        public string Password { get; set; } = string.Empty;
        public string ReturnUrl { get; set; } = "/";
    }
}
