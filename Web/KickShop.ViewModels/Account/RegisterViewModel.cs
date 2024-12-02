using KickShop.Common;
using System.ComponentModel.DataAnnotations;

public class RegisterViewModel
{
    [Required]
    [EmailAddress]
    public string Email { get; set; } = null!;

    [Required]
    [MinLength(ModelConstants.Account.PassowordMinLength,ErrorMessage = ModelConstants.Account.PassowordMinLengthError)]
    [MaxLength(ModelConstants.Account.PasswordMaxLength, ErrorMessage = ModelConstants.Account.PasswordMaxLengthError)]
    [DataType(DataType.Password)]
    public string Password { get; set; } = null!;

    [Required]
    [DataType(DataType.Password)]
    [Display(Name = "Confirm Password")]
    [Compare("Password", ErrorMessage = ModelConstants.Account.PasswordsDontMatchError)]
    public string ConfirmPassword { get; set; } = null!;
}
