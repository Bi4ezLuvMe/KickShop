using Microsoft.AspNetCore.Identity;

public class AccountService : IAccountService
{
    private readonly UserManager<ApplicationUser> userManager;
    private readonly SignInManager<ApplicationUser> signInManager;

    public AccountService(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
    {
        this.userManager = userManager;
        this.signInManager = signInManager;
    }

    public async Task<IdentityResult> RegisterUserAsync(RegisterViewModel model)
    {
        ApplicationUser user = new ApplicationUser { UserName = model.Email, Email = model.Email };
        IdentityResult createResult = await userManager.CreateAsync(user, model.Password);

        if (!createResult.Succeeded)
        {
            return createResult;
        }

        IdentityResult roleResult = await userManager.AddToRoleAsync(user, "User");

        if (!roleResult.Succeeded)
        {
            await userManager.DeleteAsync(user);
        }

        return roleResult.Succeeded ? IdentityResult.Success : roleResult;
    }

    public async Task<bool> SignInUserAsync(RegisterViewModel model)
    {
        ApplicationUser user = await userManager.FindByEmailAsync(model.Email);
        if (user == null)
        {
            return false;
        }

        SignInResult result = await signInManager.PasswordSignInAsync(user, model.Password, false, false);
        return result.Succeeded;
    }

    public async Task<SignInResult> SignInUserAsync(LoginViewModel model)
    {
        ApplicationUser user = await userManager.FindByEmailAsync(model.Email);
        if (user == null)
        {
            return SignInResult.Failed;
        }

        return await signInManager.PasswordSignInAsync(user, model.Password, model.RememberMe, false);
    }
}