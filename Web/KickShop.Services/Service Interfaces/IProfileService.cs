using KickShop.ViewModels;
using System.Threading.Tasks;

namespace KickShop.Services.Service_Interfaces
{
    public interface IProfileService
    {
        Task<ProfileViewModel> GetProfileAsync(string userId);
        Task<ProfileEditViewModel> GetProfileForEditAsync(string userId);
        Task<bool> UpdateProfileAsync(string userId, ProfileEditViewModel model);
        Task LogoutAsync();
    }
}
