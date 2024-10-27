

using KickShop.Models;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace KickShop.ViewModels
{
    public class ProductViewModel
    {
        public required Guid ProductId { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required decimal Price { get; set; }
        public string? ImageUrl { get; set; }
        public string? Action { get; set; }
    }
}
