using KickShop.Common;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace KickShop.ViewModels
{
    public class CategoryEditViewModel
    {
        [Required]
        public Guid CategoryId { get; set; }

        [Required(ErrorMessage = "The Category Name Is Required!")]
        [MinLength(ModelConstants.Category.NameMinLength, ErrorMessage = "Category Name Is Too Short!")]
        [MaxLength(ModelConstants.Category.NameMaxLength, ErrorMessage = "Category Name Is Too Long!")]
        public string Name { get; set; } = null!;
        public IFormFile? Image { get; set; }
       
    }
}
