using KickShop.Common;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace KickShop.ViewModels
{
    public class CategoryAddViewModel
    {
        [Required]
        [MinLength(ModelConstants.Category.NameMinLength)]
        [MaxLength(ModelConstants.Category.NameMaxLength)]
        public string Name { get; set; } = null!;
        [Required]
        public IFormFile Image { get; set; } = null!;
       
    }
}
