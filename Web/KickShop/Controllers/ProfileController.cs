using KickShop.Services.Service_Interfaces;
using KickShop.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

public class ProfileController : Controller
{
    private readonly IProfileService profileService;
    private readonly UserManager<ApplicationUser> userManager;

    public ProfileController(IProfileService profileService, UserManager<ApplicationUser> userManager)
    {
        this.profileService = profileService;
        this.userManager = userManager;
    }

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var userId = userManager.GetUserId(User);
        var model = await profileService.GetProfileAsync(userId);
        if (model == null) return NotFound();

        return View(model);
    }

    [HttpGet]
    public async Task<IActionResult> Edit()
    {
        var userId = userManager.GetUserId(User);
        var model = await profileService.GetProfileForEditAsync(userId);
        if (model == null) return NotFound();

        return View(model);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(ProfileEditViewModel model)
    {
        if (ModelState.IsValid)
        {
            var userId = userManager.GetUserId(User);
            var result = await profileService.UpdateProfileAsync(userId, model);

            if (result) return RedirectToAction("Index");

            ModelState.AddModelError(string.Empty, "Failed to update profile");
        }
        return View(model);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Logout()
    {
        await profileService.LogoutAsync();
        return RedirectToAction("Index", "Home");
    }
}
