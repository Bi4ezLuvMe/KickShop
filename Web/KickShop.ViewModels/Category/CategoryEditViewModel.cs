using KickShop.Common;
using Microsoft.AspNetCore.Http;
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
        public string Name { get; set; } = null!;
        [Required(ErrorMessage ="Kur")]
        public IFormFile Image { get; set; } = null!;
       
    }
}
