﻿using KickShop.Models.Enums;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace KickShop.ViewModels
{
    public class ProductDetailsViewModel
    {
        public required Guid ProductId { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required decimal Price { get; set; }
        public required int Quantity { get; set; }
        public string? MainImageUrl { get; set; }
        public required List<SelectListItem> Sizes { get; set; } = new List<SelectListItem>();
        public string? SelectedSize { get; set; }
        public required List<ProductImage> Images { get; set; } = new List<ProductImage>();
        public required List<Models.Product> RelatedProducts { get; set; } = new List<Models.Product>();
    }
}
