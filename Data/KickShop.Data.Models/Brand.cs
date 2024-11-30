using KickShop.Common;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace KickShop.Models
{
    public class Brand
    {
        public Brand()
        {
            BrandId = Guid.NewGuid();
            IsDeleted = false;
        }
        [Comment("The Unique Identifier")]
        [Key]
        public Guid BrandId { get; set; }
        [Comment("The Name Of The Brand")]
        [Required]
        [MinLength(ModelConstants.Brand.NameMinLength)]
        [MaxLength(ModelConstants.Brand.NameMaxLength)]
        public string Name { get; set; }
        [Comment("The Country Of Origin Of The The Brand")]
        [Required]
        [MinLength(ModelConstants.Brand.CountryMinLength)]
        [MaxLength(ModelConstants.Brand.CountryMaxLength)]
        public string Country { get; set; }
        [MaxLength(ModelConstants.Brand.DescriptionMaxLength)]
        public string? Description { get; set; }
        [Comment("The Address Of The Brand")]
        [Required]
        [MinLength(ModelConstants.Brand.AddressMinLength)]
        [MaxLength(ModelConstants.Brand.AddressMaxLength)]
        public string  Address { get; set; }
        [Comment("The Phone Number Of The Brand")]
        [Required]
        [MinLength(ModelConstants.Brand.PhoneNumberMinLength)]
        [MaxLength(ModelConstants.Brand.PhoneNumberMaxLength)]
        public string PhoneNumber { get; set; }
        [Comment("The Image Of The Brand")]
        [MinLength(ModelConstants.Brand.ImageUrlMinLength)]
        [MaxLength(ModelConstants.Brand.ImageUrlMaxLength)]
        public string? ImageUrl { get; set; }
        [Comment("Soft Delete Property")]
        [Required]
        public bool IsDeleted { get; set; }
    }
}
