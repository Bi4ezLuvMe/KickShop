using KickShop.Common;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace KickShop.ViewModels
{
    public class CategoryEditViewModel
    {
        [Required]
        public Guid CategoryId { get; set; }

        [Required(ErrorMessage = ModelConstants.Category.NameRequiredError)]
        [MinLength(ModelConstants.Category.NameMinLength, ErrorMessage = ModelConstants.Category.NameMinLengthError)]
        [MaxLength(ModelConstants.Category.NameMaxLength, ErrorMessage = ModelConstants.Category.NameMaxLengthError)]
        public string Name { get; set; } = null!;
        //[FileExtensions(Extensions = ModelConstants.Common.ImageFileExtentions)]
        public IFormFile? Image { get; set; }
       
    }
}
