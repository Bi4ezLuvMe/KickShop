using KickShop.Data;
using KickShop.Services;
using KickShop.Services.Service_Interfaces;
using KickShop.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Moq;
using NUnit.Framework;
using System;
using System.Threading.Tasks;

namespace KickShop.Tests
{
    [TestFixture]
    public class ProfileServiceTests
    {
        private IProfileService profileService;
        private Mock<UserManager<ApplicationUser>> userManagerMock;
        private SignInManager<ApplicationUser> signInManager;
        private KickShopDbContext context;

        [SetUp]
        public void Setup()
        {
            userManagerMock = new Mock<UserManager<ApplicationUser>>(Mock.Of<IUserStore<ApplicationUser>>(),
                null, new PasswordHasher<ApplicationUser>(), null, null, null, null, null, null);

            IHttpContextAccessor httpContextAccessor = Mock.Of<IHttpContextAccessor>();
            IUserClaimsPrincipalFactory<ApplicationUser> userClaimsPrincipalFactory = Mock.Of<IUserClaimsPrincipalFactory<ApplicationUser>>();
            signInManager = new SignInManager<ApplicationUser>(
                userManagerMock.Object,
                httpContextAccessor,
                userClaimsPrincipalFactory,
                null, null, null);

            DbContextOptions<KickShopDbContext> options = new DbContextOptionsBuilder<KickShopDbContext>()
              .UseInMemoryDatabase(Guid.NewGuid().ToString())
              .Options;

            context = new KickShopDbContext(options);
            profileService = new ProfileService(userManagerMock.Object, signInManager,context);
        }
        [TearDown]
        public void Teardown()
        {
            context.Dispose();
        }

        [Test]
        public async Task GetProfileAsyncReturnsNullWhenUserNotFound()
        {
            string userId = Guid.NewGuid().ToString();
            userManagerMock.Setup(um => um.FindByIdAsync(userId)).ReturnsAsync((ApplicationUser)null);

            ProfileViewModel result = await profileService.GetProfileAsync(userId);

            Assert.IsNull(result);
        }

        [Test]
        public async Task GetProfileAsyncReturnsProfileWhenUserFound()
        {
            ApplicationUser user = new ApplicationUser
            {
                Id = "123",
                UserName = "testuser",
                Email = "test@domain.com",
                Name = "Test User",
                Phone = "123456789",
                Image = "/images/test.jpg"
            };

            userManagerMock.Setup(um => um.FindByIdAsync("123")).ReturnsAsync(user);

            ProfileViewModel result = await profileService.GetProfileAsync(user.Id);

            Assert.IsNotNull(result);
            Assert.AreEqual(user.Id, result.UserId);
            Assert.AreEqual(user.UserName, result.UserName);
        }

        [Test]
        public async Task GetProfileForEditAsyncReturnsProfileEditModelWhenUserFound()
        {
            ApplicationUser user = new ApplicationUser
            {
                Id = "123",
                UserName = "testuser",
                Email = "test@domain.com",
                Name = "Test User",
                Phone = "123456789",
                Image = "/images/test.jpg"
            };

            userManagerMock.Setup(um => um.FindByIdAsync("123")).ReturnsAsync(user);

            ProfileEditViewModel result = await profileService.GetProfileForEditAsync(user.Id);

            Assert.IsNotNull(result);
            Assert.AreEqual(user.UserName, result.UserName);
            Assert.AreEqual(user.Email, result.Email);
        }

        [Test]
        public async Task UpdateProfileAsyncReturnsTrueWhenProfileUpdatedSuccessfully()
        {
            ApplicationUser user = new ApplicationUser
            {
                Id = "123",
                UserName = "testuser",
                Email = "test@domain.com",
                Name = "Test User",
                Phone = "123456789"
            };

            userManagerMock.Setup(um => um.FindByIdAsync("123")).ReturnsAsync(user);
            userManagerMock.Setup(um => um.UpdateAsync(It.IsAny<ApplicationUser>())).ReturnsAsync(IdentityResult.Success);

            ProfileEditViewModel model = new ProfileEditViewModel
            {
                UserName = "updateduser",
                Email = "updated@domain.com",
                Name = "Updated User",
                Phone = "987654321"
            };

            bool result = await profileService.UpdateProfileAsync(user.Id, model);

            Assert.IsTrue(result);
        }
    }
}
