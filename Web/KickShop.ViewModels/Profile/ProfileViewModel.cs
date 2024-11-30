using KickShop.Models;
using Microsoft.AspNetCore.Http;

public class ProfileViewModel
{
    public string UserId { get; set; }
    public string UserName { get; set; }
    public string Email { get; set; }
    public string Name { get; set; }
    public string Phone { get; set; }
    public IFormFile ImageFile { get; set; } 
    public string Image { get; set; }
    public List<Order> Orders { get; set; } = new List<Order>();
    public IList<string> Roles { get; set; } = new List<string>();
}
