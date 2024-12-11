using KickShop.Common;
using KickShop.Models.Enums;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using KickShop.Models;
using KickShop.ViewModels.Product;

namespace KickShop.ViewModels
{
    public class ProductEditViewModel
    {
        public Guid ProductId { get; set; }
        [Required(ErrorMessage = ModelConstants.Product.NameRequiredError)]
        [MinLength(ModelConstants.Product.NameMinLength, ErrorMessage = ModelConstants.Product.NameMinLengthError)]
        [MaxLength(ModelConstants.Product.NameMaxLength, ErrorMessage = ModelConstants.Product.NameMaxLengthError)]
        public string Name { get; set; } = null!;
        [Required(ErrorMessage = ModelConstants.Product.DescriptionRequiredError)]
        [MinLength(ModelConstants.Product.DescriptionMinLength, ErrorMessage = ModelConstants.Product.DescriptionMinLengthError)]
        [MaxLength(ModelConstants.Product.DescriptionMaxLength, ErrorMessage = ModelConstants.Product.DescriptionMaxLengthError)]
        public string Description { get; set; } = null!;
        [Required]
        [Range(ModelConstants.Product.PriceRangeMin, ModelConstants.Product.PriceRangeMax, ErrorMessage = ModelConstants.Product.InvalidPriceError)]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Price { get; set; }
        [Required]
        [Range(ModelConstants.Product.QuantityRangeMin, ModelConstants.Product.QuantityRangeMax, ErrorMessage = ModelConstants.Product.InvalidQuantityError)]
        public int StockQuantity { get; set; }
        public string? MainImageUrl { get; set; }
        //[FileExtensions(Extensions = ModelConstants.Common.ImageFileExtentions, ErrorMessage = ModelConstants.Common.ImageFileExtentionError)]
        public List<IFormFile>? Images { get; set; }
        public List<string>? ExistingImages { get; set; }
        [Required]
        public Guid CategoryId { get; set; }
        [Required]
        public Guid BrandId { get; set; }
        [Required]
        public List<ProductSizeViewModel> Sizes { get; set; } = new List<ProductSizeViewModel>();
    }
}
