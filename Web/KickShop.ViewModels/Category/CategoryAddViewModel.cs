using KickShop.Common;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace KickShop.ViewModels
{
    public class CategoryAddViewModel
    {
        [Required(ErrorMessage ="The Category Name Is Required!")]
        [MinLength(ModelConstants.Category.NameMinLength,ErrorMessage ="Category Name Is Too Short!")]
        [MaxLength(ModelConstants.Category.NameMaxLength,ErrorMessage ="Category Name Is Too Long!")]
        public string Name { get; set; } = null!;
        [Required(ErrorMessage ="The Category Image Is Required!")]
        public IFormFile Image { get; set; } = null!;
       
    }
}
