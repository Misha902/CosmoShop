using System.ComponentModel.DataAnnotations;
namespace CosmoShop.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Username")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Password missmatch")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm your password")]
        public string PasswordConfirm { get; set; }
    }
}
