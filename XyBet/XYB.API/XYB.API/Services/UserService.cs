using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using XYB.API.Options;
using XYB.API.Services.Abstractions;
using XYB.Data.Entities;

namespace XYB.API.Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<AppUser> _userManager;

        public UserService(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IdentityResult> CreateUserAsync(AppUser appUser, string password)
        {
            return await _userManager.CreateAsync(appUser, password);
        }

        public async Task<IdentityResult> AddToRoleAsync(AppUser appUser, string appRole)
        {
            return await _userManager.AddToRoleAsync(appUser, appRole);
        }
    }
}
