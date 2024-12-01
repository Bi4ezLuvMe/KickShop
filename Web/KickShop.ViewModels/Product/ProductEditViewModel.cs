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
        [Required(ErrorMessage = "The Product Name Is Required!")]
        [MinLength(ModelConstants.Product.NameMinLength, ErrorMessage = "The Product Name Is Too Short!")]
        [MaxLength(ModelConstants.Product.NameMaxLength, ErrorMessage = "The Product Name Is Too Long!")]
        public string Name { get; set; } = null!;
        [Required(ErrorMessage = "The Product Description Is Required!")]
        [MinLength(ModelConstants.Product.DescriptionMinLength, ErrorMessage = "The Product Description Is Too Short!")]
        [MaxLength(ModelConstants.Product.DescriptionMaxLength, ErrorMessage = "The Product Description Is Too Long!")]
        public string Description { get; set; } = null!;
        [Required]
        [Range(ModelConstants.Product.PriceRangeMin, ModelConstants.Product.PriceRangeMax, ErrorMessage = "Invalid Price!")]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Price { get; set; }
        [Required]
        [Range(ModelConstants.Product.QuantityRangeMin, ModelConstants.Product.QuantityRangeMax, ErrorMessage = "Invalid Stock Quantity!")]
        public int StockQuantity { get; set; }
        public string? MainImageUrl { get; set; }
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
