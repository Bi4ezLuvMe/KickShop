using KickShop.Services;
using KickShop.Services.Service_Interfaces;
using KickShop.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
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

        [SetUp]
        public void Setup()
        {
            userManagerMock = new Mock<UserManager<ApplicationUser>>(Mock.Of<IUserStore<ApplicationUser>>(),
                null, new PasswordHasher<ApplicationUser>(), null, null, null, null, null, null);

            var httpContextAccessor = Mock.Of<IHttpContextAccessor>();
            var userClaimsPrincipalFactory = Mock.Of<IUserClaimsPrincipalFactory<ApplicationUser>>();
            signInManager = new SignInManager<ApplicationUser>(
                userManagerMock.Object,
                httpContextAccessor,
                userClaimsPrincipalFactory,
                null, null, null);

            profileService = new ProfileService(userManagerMock.Object, signInManager);
        }

        [Test]
        public async Task GetProfileAsync_ReturnsNull_WhenUserNotFound()
        {
            // Arrange
            var userId = Guid.NewGuid().ToString(); // Non-existing user
            userManagerMock.Setup(um => um.FindByIdAsync(userId)).ReturnsAsync((ApplicationUser)null);

            // Act
            var result = await profileService.GetProfileAsync(userId);

            // Assert
            Assert.IsNull(result);
        }

        [Test]
        public async Task GetProfileAsync_ReturnsProfile_WhenUserFound()
        {
            // Arrange
            var user = new ApplicationUser
            {
                Id = "123",
                UserName = "testuser",
                Email = "test@domain.com",
                Name = "Test User",
                Phone = "123456789",
                Image = "/images/test.jpg"
            };

            userManagerMock.Setup(um => um.FindByIdAsync("123")).ReturnsAsync(user);

            // Act
            var result = await profileService.GetProfileAsync(user.Id);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(user.Id, result.UserId);
            Assert.AreEqual(user.UserName, result.UserName);
        }

        [Test]
        public async Task GetProfileForEditAsync_ReturnsProfileEditModel_WhenUserFound()
        {
            // Arrange
            var user = new ApplicationUser
            {
                Id = "123",
                UserName = "testuser",
                Email = "test@domain.com",
                Name = "Test User",
                Phone = "123456789",
                Image = "/images/test.jpg"
            };

            userManagerMock.Setup(um => um.FindByIdAsync("123")).ReturnsAsync(user);

            // Act
            var result = await profileService.GetProfileForEditAsync(user.Id);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(user.UserName, result.UserName);
            Assert.AreEqual(user.Email, result.Email);
        }

        [Test]
        public async Task UpdateProfileAsync_ReturnsTrue_WhenProfileUpdatedSuccessfully()
        {
            // Arrange
            var user = new ApplicationUser
            {
                Id = "123",
                UserName = "testuser",
                Email = "test@domain.com",
                Name = "Test User",
                Phone = "123456789"
            };

            userManagerMock.Setup(um => um.FindByIdAsync("123")).ReturnsAsync(user);
            userManagerMock.Setup(um => um.UpdateAsync(It.IsAny<ApplicationUser>())).ReturnsAsync(IdentityResult.Success);

            var model = new ProfileEditViewModel
            {
                UserName = "updateduser",
                Email = "updated@domain.com",
                Name = "Updated User",
                Phone = "987654321"
            };

            // Act
            var result = await profileService.UpdateProfileAsync(user.Id, model);

            // Assert
            Assert.IsTrue(result);
        }
    }
}
