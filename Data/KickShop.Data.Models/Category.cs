using KickShop.Common;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace KickShop.Models
{
    public class Category
    {
        public Category()
        {
            CategoryId = Guid.NewGuid();
            Products = new HashSet<Product>();
            IsDeleted = false;
        }
        [Comment("The Unique Identifier")]
        [Key]
        public Guid CategoryId { get; set; }
        [Comment("The Name Of The Category")]
        [Required]
        [MinLength(ModelConstants.Category.NameMinLength)]
        [MaxLength(ModelConstants.Category.NameMaxLength)]
        public string Name { get; set; }
        [Comment("Navigation Property for relateed products")]
        public HashSet<Product> Products { get; set; }
        [Comment("Image For The Category")]
        [MinLength(ModelConstants.Category.ImageUrlMinLength)]
        [MaxLength(ModelConstants.Category.ImageUrlMaxLength)]
        public string ImageUrl { get; set; }
        [Comment("Soft Delete Property")]
        [Required]
        public bool IsDeleted { get; set; }
    }
}
