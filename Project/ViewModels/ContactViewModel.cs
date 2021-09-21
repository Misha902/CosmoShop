using System.ComponentModel.DataAnnotations;

namespace CosmoShop.ViewModels
{
    public class ContactViewModel
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [MaxLength(250)]
        public string Message { get; set; }
    }
}
