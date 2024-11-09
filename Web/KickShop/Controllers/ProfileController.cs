using KickShop.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

public class ProfileController : Controller
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly SignInManager<ApplicationUser> signInManager;
    public ProfileController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> _signInManager)
    {
        _userManager = userManager;
        signInManager = _signInManager;
    }
    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var user = await _userManager.GetUserAsync(User);
        var model = new ProfileViewModel()
        {
            UserId = user.Id,
            UserName = user.UserName,
            Email = user.Email,
            Name = user.Name,
            Phone = user.Phone,
            Image = user.Image 
        };
        return View(model);
    }
    [HttpGet]
    public async Task<IActionResult> Edit()
    {
        var user =await GetUserAsync();
        var model = new ProfileEditViewModel()
        {
            UserName = user.UserName,
            Email = user.Email,
            Name = user.Name,
            Phone = user.Phone,
            Image = user.Image
        };
        return View(model);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(ProfileEditViewModel model)
    {
        if (ModelState.IsValid)
        {
            var user = await _userManager.FindByIdAsync(GetUserAsync().Result.Id);
            if (user != null)
            {
                user.UserName = model.UserName;
                user.Email = model.Email;
                user.Name = model.Name;
                user.Phone = model.Phone;

                if (model.ImageFile != null && model.ImageFile.Length > 0)
                {
                    var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images");
                    if (!Directory.Exists(uploadsFolder))
                    {
                        Directory.CreateDirectory(uploadsFolder);
                    }

                    var filePath = Path.Combine(uploadsFolder, model.ImageFile.FileName);

                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await model.ImageFile.CopyToAsync(stream);
                    }

                    user.Image = "/images/" + model.ImageFile.FileName;
                }

                var result = await _userManager.UpdateAsync(user);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }
        }
        return View(model);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Logout()
    {
        await signInManager.SignOutAsync();
        return RedirectToAction("Index", "Home");
    }
    private async Task<ApplicationUser> GetUserAsync()
    {
        return await _userManager.GetUserAsync(User);
    }
}