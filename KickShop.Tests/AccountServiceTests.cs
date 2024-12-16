using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Moq;

[TestFixture]
public class AccountServiceTests
{
    private Mock<UserManager<ApplicationUser>> userManagerMock;
    private Mock<SignInManager<ApplicationUser>> signInManagerMock;
    private IAccountService accountService;

    [SetUp]
    public void Setup()
    {
        userManagerMock = new Mock<UserManager<ApplicationUser>>(Mock.Of<IUserStore<ApplicationUser>>(),
                null, new PasswordHasher<ApplicationUser>(), null, null, null, null, null, null);

        IHttpContextAccessor httpContextAccessor = Mock.Of<IHttpContextAccessor>();
        IUserClaimsPrincipalFactory<ApplicationUser> userClaimsPrincipalFactory = Mock.Of<IUserClaimsPrincipalFactory<ApplicationUser>>();
        var httpContextAccessorMock = Mock.Of<IHttpContextAccessor>();
        var userClaimsPrincipalFactoryMock = Mock.Of<IUserClaimsPrincipalFactory<ApplicationUser>>();
        var identityOptionsMock = Mock.Of<IOptions<IdentityOptions>>();
        var loggerMock = Mock.Of<ILogger<SignInManager<ApplicationUser>>>();
        var authenticationSchemeProviderMock = Mock.Of<IAuthenticationSchemeProvider>();
        var userConfirmationMock = Mock.Of<IUserConfirmation<ApplicationUser>>();

        signInManagerMock = new Mock<SignInManager<ApplicationUser>>(
            userManagerMock.Object,
            httpContextAccessorMock,
            userClaimsPrincipalFactoryMock,
            identityOptionsMock,
            loggerMock,
            authenticationSchemeProviderMock,
            userConfirmationMock
        );
        accountService = new AccountService(userManagerMock.Object, signInManagerMock.Object);
    }

    [Test]
    public async Task RegisterUserAsyncReturnsTrue()
    {
        var model = new RegisterViewModel { Email = "test@example.com", Password = "Password123!" };
        userManagerMock.Setup(x => x.CreateAsync(It.IsAny<ApplicationUser>(), It.IsAny<string>()))
            .ReturnsAsync(IdentityResult.Success);
        userManagerMock.Setup(x => x.AddToRoleAsync(It.IsAny<ApplicationUser>(), It.IsAny<string>()))
            .ReturnsAsync(IdentityResult.Success);

        var result = await accountService.RegisterUserAsync(model);

        Assert.IsTrue(result.Succeeded);
        userManagerMock.Verify(x => x.CreateAsync(It.IsAny<ApplicationUser>(), model.Password), Times.Once);
        userManagerMock.Verify(x => x.AddToRoleAsync(It.IsAny<ApplicationUser>(), "User"), Times.Once);
    }

    [Test]
    public async Task SignInUserAsyncReturnsTrueWhenSuccessful()
    {
        var model = new LoginViewModel { Email = "test@example.com", Password = "Password123!" };
        var user = new ApplicationUser { Email = model.Email };
        userManagerMock.Setup(x => x.FindByEmailAsync(model.Email)).ReturnsAsync(user);
        signInManagerMock.Setup(x => x.PasswordSignInAsync(user, model.Password, false, false))
            .ReturnsAsync(SignInResult.Success);

        var result = await accountService.SignInUserAsync(model);

        Assert.IsTrue(result.Succeeded);
        userManagerMock.Verify(x => x.FindByEmailAsync(model.Email), Times.Once);
        signInManagerMock.Verify(x => x.PasswordSignInAsync(user, model.Password, false, false), Times.Once);
    }

    [Test]
    public async Task SignInUserAsyncReturnsSignInResult()
    {
        var model = new LoginViewModel { Email = "test@example.com", Password = "Password123!", RememberMe = true };
        var user = new ApplicationUser { Email = model.Email };
        userManagerMock.Setup(x => x.FindByEmailAsync(model.Email)).ReturnsAsync(user);
        signInManagerMock.Setup(x => x.PasswordSignInAsync(user, model.Password, model.RememberMe, false))
            .ReturnsAsync(SignInResult.Success);

        var result = await accountService.SignInUserAsync(model);

        Assert.IsTrue(result.Succeeded);
        userManagerMock.Verify(x => x.FindByEmailAsync(model.Email), Times.Once);
        signInManagerMock.Verify(x => x.PasswordSignInAsync(user, model.Password, model.RememberMe, false), Times.Once);
    }
    [Test]
    public async Task RegisterUserAsyncReturnsFalseWhenCreateFails()
    {
        RegisterViewModel model = new RegisterViewModel { Email = "test@example.com", Password = "Password123!" };

        userManagerMock.Setup(x => x.CreateAsync(It.IsAny<ApplicationUser>(), It.IsAny<string>()))
            .ReturnsAsync(IdentityResult.Failed(new IdentityError { Description = "Error creating user" }));

        IdentityResult result = await accountService.RegisterUserAsync(model);

        Assert.IsFalse(result.Succeeded);
        userManagerMock.Verify(x => x.CreateAsync(It.IsAny<ApplicationUser>(), model.Password), Times.Once);
        userManagerMock.Verify(x => x.AddToRoleAsync(It.IsAny<ApplicationUser>(), "User"), Times.Never);
    }
    [Test]
    public async Task RegisterUserAsyncReturnsFalseWhenRoleAssignmentFails()
    {
        RegisterViewModel model = new RegisterViewModel { Email = "test@example.com", Password = "Password123!" };
        userManagerMock.Setup(x => x.CreateAsync(It.IsAny<ApplicationUser>(), It.IsAny<string>()))
            .ReturnsAsync(IdentityResult.Success);

        userManagerMock.Setup(x => x.AddToRoleAsync(It.IsAny<ApplicationUser>(), It.IsAny<string>()))
            .ReturnsAsync(IdentityResult.Failed(new IdentityError { Description = "Error assigning role" }));

        IdentityResult result = await accountService.RegisterUserAsync(model);

        Assert.IsFalse(result.Succeeded);
        userManagerMock.Verify(x => x.CreateAsync(It.IsAny<ApplicationUser>(), model.Password), Times.Once);
        userManagerMock.Verify(x => x.AddToRoleAsync(It.IsAny<ApplicationUser>(), "User"), Times.Once);
    }
    [Test]
    public async Task SignInUserAsyncReturnsFalseWhenPasswordIsIncorrect()
    {
        LoginViewModel model = new LoginViewModel { Email = "test@example.com", Password = "IncorrectPassword" };
        ApplicationUser user = new ApplicationUser { Email = model.Email };

        userManagerMock.Setup(x => x.FindByEmailAsync(model.Email)).ReturnsAsync(user);
        signInManagerMock.Setup(x => x.PasswordSignInAsync(user, model.Password, false, false))
            .ReturnsAsync(SignInResult.Failed);

        SignInResult result = await accountService.SignInUserAsync(model);

        Assert.IsFalse(result.Succeeded);
        userManagerMock.Verify(x => x.FindByEmailAsync(model.Email), Times.Once);
        signInManagerMock.Verify(x => x.PasswordSignInAsync(user, model.Password, false, false), Times.Once);
    }
    [Test]
    public async Task SignInUserAsyncWithRememberMeReturnsTrueWhenSuccessful()
    {
        LoginViewModel model = new LoginViewModel { Email = "test@example.com", Password = "Password123!", RememberMe = true };
        ApplicationUser user = new ApplicationUser { Email = model.Email };

        userManagerMock.Setup(x => x.FindByEmailAsync(model.Email)).ReturnsAsync(user);
        signInManagerMock.Setup(x => x.PasswordSignInAsync(user, model.Password, model.RememberMe, false))
            .ReturnsAsync(SignInResult.Success);

        SignInResult result = await accountService.SignInUserAsync(model);

        Assert.IsTrue(result.Succeeded);
        userManagerMock.Verify(x => x.FindByEmailAsync(model.Email), Times.Once);
        signInManagerMock.Verify(x => x.PasswordSignInAsync(user, model.Password, model.RememberMe, false), Times.Once);
    }

}
