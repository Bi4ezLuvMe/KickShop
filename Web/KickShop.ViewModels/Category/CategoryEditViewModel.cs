using KickShop.Common;
using System.ComponentModel.DataAnnotations;

namespace KickShop.ViewModels
{
    public class CategoryEditViewModel
    {
        [Required]
        public Guid CategoryId { get; set; }

        [Required]
        [MinLength(ModelConstants.Category.NameMinLength)]
        [MaxLength(ModelConstants.Category.NameMaxLength)]
        public string Name { get; set; }

        [MinLength(ModelConstants.Category.ImageUrlMinLength)]
        [MaxLength(ModelConstants.Category.ImageUrlMaxLength)]
        public string? ImageUrl { get; set; }
    }
}
