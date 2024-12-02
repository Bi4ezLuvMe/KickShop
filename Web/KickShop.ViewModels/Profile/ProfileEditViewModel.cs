using KickShop.Common;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace KickShop.ViewModels
{
    public class ProfileEditViewModel
    {

        [Required(ErrorMessage = ModelConstants.Profile.UserNameRequiredError)]
        [MinLength(ModelConstants.Profile.UserNameMinLength, ErrorMessage = ModelConstants.Profile.UserNameMinLengthError)]
        [MaxLength(ModelConstants.Profile.UserNameMaxLength, ErrorMessage = ModelConstants.Profile.UserNameMaxLengthError)]
        public string UserName { get; set; } = null!;

        [Required(ErrorMessage = ModelConstants.Profile.EmailRequiredError)]
        [EmailAddress(ErrorMessage = ModelConstants.Profile.InvalidEmailError)]
        public string Email { get; set; } = null!;

        [Required(ErrorMessage = ModelConstants.Profile.NameRequiredError)]
        [MinLength(ModelConstants.Profile.NameMinLength, ErrorMessage = ModelConstants.Profile.NameMinLengthError)]
        [MaxLength(ModelConstants.Profile.NameMaxLength, ErrorMessage = ModelConstants.Profile.NameMaxLengthError)]
        public string Name { get; set; } = null!;

        [Phone(ErrorMessage = ModelConstants.Profile.InvalidPhoneNumberError)]
        public string Phone { get; set; } = null!;

        public IFormFile? ImageFile { get; set; }
        public string? Image { get; set; }
    }
}
