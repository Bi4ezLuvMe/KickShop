
namespace KickShop.ViewModels
{
    public class CategoryViewModel
    {
        public required Guid CategoryId { get; set; }
        public required string Name { get; set; }
        public string? ImageUrl { get; set; }
    }
}
