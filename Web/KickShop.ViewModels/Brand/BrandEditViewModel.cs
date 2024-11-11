using KickShop.Common;
using System;
using System.ComponentModel.DataAnnotations;

namespace KickShop.ViewModels
{
    public class BrandEditViewModel
    {
        [Required]
        public Guid BrandId { get; set; }

        [Required]
        [MinLength(ModelConstants.Brand.NameMinLength)]
        [MaxLength(ModelConstants.Brand.NameMaxLength)]
        public string Name { get; set; }

        [Required]
        [MinLength(ModelConstants.Brand.CountryMinLength)]
        [MaxLength(ModelConstants.Brand.CountryMaxLength)]
        public string Country { get; set; }

        [Required]
        [MinLength(ModelConstants.Brand.AddressMinLength)]
        [MaxLength(ModelConstants.Brand.AddressMaxLength)]
        public string Address { get; set; }

        [Required]
        [MinLength(ModelConstants.Brand.PhoneNumberMinLength)]
        [MaxLength(ModelConstants.Brand.PhoneNumberMaxLength)]
        public string PhoneNumber { get; set; }

        [MinLength(ModelConstants.Brand.ImageUrlMinLength)]
        [MaxLength(ModelConstants.Brand.ImageUrlMaxLength)]
        public string? ImageUrl { get; set; }
    }
}
