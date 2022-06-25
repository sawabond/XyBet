using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using XYB.API.Services.Abstractions;
using XYB.Data.Entities;

namespace XYB.API.Services
{
    public class SignInManager : ISignInManager
    {
        private readonly SignInManager<AppUser> _signInManagerDelegated;

        public SignInManager(SignInManager<AppUser> signInManagerDelegated)
        {
            _signInManagerDelegated = signInManagerDelegated;
        }

        public async Task<SignInResult> CheckPasswordSignInAsync(AppUser user, string password, bool lockoutOnFailur)
        {
            return await _signInManagerDelegated.CheckPasswordSignInAsync(user, password, lockoutOnFailur);
        }
    }
}
