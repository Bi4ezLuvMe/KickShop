using Microsoft.AspNetCore.Mvc;

namespace KickShop.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
