using KickShop.Models;
using Microsoft.AspNetCore.Http;

public class ProfileViewModel
{
    public string UserId { get; set; } = null!;
    public string UserName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Name { get; set; } = null!;
    public string Phone { get; set; } = null!;
    public IFormFile ImageFile { get; set; } = null!;
    public string Image { get; set; } = null!;
    public List<Order> Orders { get; set; } = new List<Order>();
}
