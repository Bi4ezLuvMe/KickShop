using KickShop.Services.Service_Interfaces;
using KickShop.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

public class ProfileController : Controller
{
    private readonly IProfileService profileService;
    private readonly UserManager<ApplicationUser> userManager;
    private readonly RoleManager<IdentityRole> roleManager;

    public ProfileController(IProfileService profileService, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
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

        var user = await userManager.FindByIdAsync(userId);
        model.Roles = await userManager.GetRolesAsync(user);

        return View(model);
    }
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> AssignRoleToUser(string userId, string roleName)
    {
        var user = await userManager.FindByIdAsync(userId);
        if (user == null)
        {
            return NotFound();
        }

        var roleExist = await roleManager.RoleExistsAsync(roleName);
        if (!roleExist)
        {
            return BadRequest("Role does not exist.");
        }

        var result = await userManager.AddToRoleAsync(user, roleName);
        if (result.Succeeded)
        {
            return RedirectToAction("Index", "Profile");
        }

        return BadRequest("Failed to assign role.");
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
