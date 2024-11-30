using Microsoft.AspNetCore.Identity;

public interface IAccountService
{
    Task<IdentityResult> RegisterUserAsync(RegisterViewModel model);
    Task<bool> SignInUserAsync(RegisterViewModel model);
    Task<SignInResult> SignInUserAsync(LoginViewModel model);
}
