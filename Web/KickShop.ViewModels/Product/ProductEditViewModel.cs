﻿using KickShop.Common;
using KickShop.Models.Enums;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace KickShop.ViewModels
{
    public class ProductEditViewModel
    {
        public Guid ProductId { get; set; }
        [Required]
        [MinLength(ModelConstants.Product.NameMinLength)]
        [MaxLength(ModelConstants.Product.NameMaxLength)]
        public string Name { get; set; } = null!;
        [Required]
        [MinLength(ModelConstants.Product.DescriptionMinLength)]
        [MaxLength(ModelConstants.Product.DescriptionMaxLength)]
        public string Description { get; set; } = null!;
        [Required]
        [Range(ModelConstants.Product.PriceRangeMin, ModelConstants.Product.PriceRangeMax)]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Price { get; set; }
        [Required]
        [Range(ModelConstants.Product.QuantityRangeMin, ModelConstants.Product.QuantityRangeMax)]
        public int StockQuantity { get; set; }
        public string? MainImageUrl { get; set; }
        [Required]
        public Guid CategoryId { get; set; }
        [Required]
        public Guid BrandId { get; set; }
        [Required]
        public List<Sizes> Sizes { get; set; }
    }
}
