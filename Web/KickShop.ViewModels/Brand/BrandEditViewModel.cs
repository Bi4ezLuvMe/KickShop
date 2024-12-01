using KickShop.Common;
using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;

namespace KickShop.ViewModels
{
    public class BrandEditViewModel
    {
        [Required]
        public Guid BrandId { get; set; }


        [Required(ErrorMessage = "The Brand Name Is Required!")]
        [MinLength(ModelConstants.Brand.NameMinLength, ErrorMessage = "The Brand Name Is Too Short!")]
        [MaxLength(ModelConstants.Brand.NameMaxLength, ErrorMessage = "The Brand Name Is Too Long!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The Brand Country Is Required!")]
        [MinLength(ModelConstants.Brand.CountryMinLength, ErrorMessage = "The Brand Country Is Too Short!")]
        [MaxLength(ModelConstants.Brand.CountryMaxLength, ErrorMessage = "The Brand Country Is Too Long!")]
        public string Country { get; set; }

        [Required(ErrorMessage = "The Brand Address Is Required!")]
        [MinLength(ModelConstants.Brand.AddressMinLength, ErrorMessage = "The Brand Address Is Too Short!")]
        [MaxLength(ModelConstants.Brand.AddressMaxLength, ErrorMessage = "The Brand Address Is Too Long!")]
        public string Address { get; set; }

        [Required(ErrorMessage = "The Brand Phone Number Is REquired!")]
        [MinLength(ModelConstants.Brand.PhoneNumberMinLength, ErrorMessage = "The Brand Phone Number Is Too Short!")]
        [MaxLength(ModelConstants.Brand.PhoneNumberMaxLength, ErrorMessage = "The Brand Phone Number Is Too Long!")]
        public string PhoneNumber { get; set; }

        public IFormFile? Image { get; set; }
        public string? OldImageUrl { get; set; }
    }
}
