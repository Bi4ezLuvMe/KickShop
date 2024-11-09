namespace KickShop.ViewModels
{
    public class ProductViewModel
    {
        public required Guid ProductId { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required decimal Price { get; set; }
        public string? ImageUrl { get; set; }
        public required string CategoryId { get; set; }
    }
}
