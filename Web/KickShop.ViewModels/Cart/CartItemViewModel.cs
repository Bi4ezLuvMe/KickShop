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
        public string? ImageUrl { get; set; }
    }


}
