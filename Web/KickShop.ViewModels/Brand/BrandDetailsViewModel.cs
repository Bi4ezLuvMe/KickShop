using System;

namespace KickShop.ViewModels
{
    public class BrandDetailsViewModel
    {
        public required Guid BrandId { get; set; }

        public required string Name { get; set; }

        public required string Country { get; set; }

        public required string Address { get; set; }

        public required string PhoneNumber { get; set; }
        public string Description { get; set; }

        public string? ImageUrl { get; set; }
    }
}
