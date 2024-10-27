using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

public class ProfileController : Controller
{
    private readonly UserManager<IdentityUser> _userManager;

    public ProfileController(UserManager<IdentityUser> userManager)
    {
        _userManager = userManager;
    }
    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var user = await _userManager.GetUserAsync(User);
        var model = new ProfileViewModel
        {
            UserId = user.Id,
            UserName = user.UserName,
            Email = user.Email
        };
        return View(model);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Index(ProfileViewModel model)
    {
        if (ModelState.IsValid)
        {
            var user = await _userManager.FindByIdAsync(model.UserId);
            if (user != null)
            {
                user.UserName = model.UserName;
                user.Email = model.Email;

                var result = await _userManager.UpdateAsync(user);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }
        }
        return View(model);
    }
}