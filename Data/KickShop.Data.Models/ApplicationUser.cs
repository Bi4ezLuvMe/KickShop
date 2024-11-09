using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

public class ApplicationUser : IdentityUser
{
    public string Name { get; set; }
    public string Phone { get; set; }
    [NotMapped]
    public IFormFile ImageFile { get; set; }
    public string Image { get; set; }
}
