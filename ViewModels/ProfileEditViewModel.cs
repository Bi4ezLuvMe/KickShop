using System.ComponentModel.DataAnnotations;

namespace KickShop.ViewModels
{
    public class ProfileEditViewModel
    {
        
        [Required(ErrorMessage = "Username is required.")]
        public string UserName { get; set; } 

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; } 

        [Phone(ErrorMessage = "Invalid phone number.")]
        public string Phone { get; set; } 

        public IFormFile? ImageFile { get; set; }
        public string? Image { get; set; }
    }
}
