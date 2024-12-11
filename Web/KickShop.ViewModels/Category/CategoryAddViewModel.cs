using KickShop.Common;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace KickShop.ViewModels
{
    public class CategoryAddViewModel
    {
        [Required(ErrorMessage =ModelConstants.Category.NameRequiredError)]
        [MinLength(ModelConstants.Category.NameMinLength,ErrorMessage =ModelConstants.Category.NameMinLengthError)]
        [MaxLength(ModelConstants.Category.NameMaxLength,ErrorMessage =ModelConstants.Category.NameMaxLengthError)]
        public string Name { get; set; } = null!;
        [Required(ErrorMessage =ModelConstants.Category.ImageRequiredError)]
        //[FileExtensions(Extensions = ModelConstants.Common.ImageFileExtentions,ErrorMessage =ModelConstants.Common.ImageFileExtentionError)]
        public IFormFile Image { get; set; } = null!;
       
    }
}
