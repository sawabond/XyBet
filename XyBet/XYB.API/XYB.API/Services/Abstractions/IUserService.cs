using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using XYB.Data.Entities;

namespace XYB.API.Services.Abstractions
{
    public interface IUserService
    {
        public Task<IdentityResult> CreateUserAsync(AppUser appUser, string password);

        Task<IdentityResult> AddToRoleAsync(AppUser appUser, string appRole);
    }
}
