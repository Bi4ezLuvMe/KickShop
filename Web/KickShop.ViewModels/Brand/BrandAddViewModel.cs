using KickShop.Common;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace KickShop.ViewModels
{
    public class BrandAddViewModel
    {
        [Required(ErrorMessage = ModelConstants.Brand.NameRequiredError)]
        [MinLength(ModelConstants.Brand.NameMinLength, ErrorMessage = ModelConstants.Brand.NameMinLengthError)]
        [MaxLength(ModelConstants.Brand.NameMaxLength, ErrorMessage = ModelConstants.Brand.NameMaxLengthError)]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = ModelConstants.Brand.CountryRequiredError)]
        [MinLength(ModelConstants.Brand.CountryMinLength, ErrorMessage = ModelConstants.Brand.CountryMinLengthError)]
        [MaxLength(ModelConstants.Brand.CountryMaxLength, ErrorMessage = ModelConstants.Brand.CountryMaxLengthError)]
        public string Country { get; set; } = null!;

        [Required(ErrorMessage = ModelConstants.Brand.AddressRequiredError)]
        [MinLength(ModelConstants.Brand.AddressMinLength, ErrorMessage = ModelConstants.Brand.AddressMinLengthError)]
        [MaxLength(ModelConstants.Brand.AddressMaxLength, ErrorMessage = ModelConstants.Brand.AddressMaxLengthError)]
        public string Address { get; set; } = null!;

        [Required(ErrorMessage = ModelConstants.Brand.PhoneNumberRequiredError)]
        [MinLength(ModelConstants.Brand.PhoneNumberMinLength, ErrorMessage = ModelConstants.Brand.PhoneNumberMinLengthError)]
        [MaxLength(ModelConstants.Brand.PhoneNumberMaxLength, ErrorMessage = ModelConstants.Brand.PhoneNumberMaxLengthError)]
        public string PhoneNumber { get; set; } = null!;

        [Required(ErrorMessage =ModelConstants.Brand.ImageRequiredError)]
        public IFormFile Image { get; set; } = null!;
    }
}
