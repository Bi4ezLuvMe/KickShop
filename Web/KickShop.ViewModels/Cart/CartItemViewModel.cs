using KickShop.Models;

namespace KickShop.ViewModels
{
    public class CartItemViewModel
    {
        public required Guid ProductId { get; set; }
        public required string ProductName { get; set; }
        public required int Quantity { get; set; }
        public required decimal Price { get; set; }
        public required decimal TotalPrice { get; set; }
        public required string Size { get; set; }
        public string? MainImageUrl { get; set; }
    }
}
