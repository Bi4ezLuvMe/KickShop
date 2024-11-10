using KickShop.Common;
using KickShop.Models.Enums;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KickShop.Models
{
    public class Product
    {
        public Product()
        {
            ProductId = Guid.NewGuid();
        }
        [Comment("The Unique Identifier")]
        [Key]
        public Guid ProductId { get; set; }
        [Comment("The Product Name")]
        [Required]
        [MinLength(ModelConstants.Product.NameMinLength)]
        [MaxLength(ModelConstants.Product.NameMaxLength)]
        public string Name { get; set; } = null!;
        [Comment("The Description For The Product")]
        [Required]
        [MinLength(ModelConstants.Product.DescriptionMinLength)]
        [MaxLength(ModelConstants.Product.DescriptionMaxLength)]
        public string Description { get; set; } = null!;
        [Comment("The Price Of The Product")]
        [Required]
        [Range(ModelConstants.Product.PriceRangeMin, ModelConstants.Product.PriceRangeMax)]
        [Column(TypeName ="decimal(10,2)")]
        public decimal Price { get; set; }
        [Comment("Current Stock Quantity")]
        [Required]
        [Range(ModelConstants.Product.QuantityRangeMin, ModelConstants.Product.QuantityRangeMax)]
        public int StockQuantity { get; set; }
        [Comment("URL To The Product Image")]
        public string? ImageUrl { get; set; }
        [Comment("Foreign Key To The Category Entity")]
        [Required]
        public Guid CategoryId { get; set; }
        [Comment("The Category Of The Product")]
        [Required]
        [ForeignKey("CategoryId")]
        public Category Category { get; set; } = null!;
        [Comment("Foreign Key To The Brand Entity")]
        [Required]
        public Guid BrandId { get; set; }
        [Comment("The Brand Of The Product")]
        [Required]
        [ForeignKey("BrandId")]
        public Brand Brand { get; set; } = null!;
        [Comment("Soft Delete Property")]
        [Required]
        public bool IsDeleted { get; set; } = false;
        [Comment("The Size Of The Product")]
        [Required]
        public List<Sizes> Sizes { get; set; }
    }
}
