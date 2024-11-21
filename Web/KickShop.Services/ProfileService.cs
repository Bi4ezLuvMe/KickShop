using KickShop.Services.Service_Interfaces;
using KickShop.ViewModels;
using Microsoft.AspNetCore.Identity;
using System.IO;
using System.Threading.Tasks;

namespace KickShop.Services
{
    public class ProfileService : IProfileService
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;

        public ProfileService(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        public async Task<ProfileViewModel> GetProfileAsync(string userId)
        {
            var user = await userManager.FindByIdAsync(userId);
            if (user == null) return null;

            return new ProfileViewModel
            {
                UserId = user.Id,
                UserName = user.UserName,
                Email = user.Email,
                Name = user.Name,
                Phone = user.Phone,
                Image = user.Image
            };
        }

        public async Task<ProfileEditViewModel> GetProfileForEditAsync(string userId)
        {
            var user = await userManager.FindByIdAsync(userId);
            if (user == null) return null;

            return new ProfileEditViewModel
            {
                UserName = user.UserName,
                Email = user.Email,
                Name = user.Name,
                Phone = user.Phone,
                Image = user.Image
            };
        }

        public async Task<bool> UpdateProfileAsync(string userId, ProfileEditViewModel model)
        {
            var user = await userManager.FindByIdAsync(userId);
            if (user == null) return false;

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

            var result = await userManager.UpdateAsync(user);
            return result.Succeeded;
        }

        public async Task LogoutAsync()
        {
            await signInManager.SignOutAsync();
        }
    }
}
