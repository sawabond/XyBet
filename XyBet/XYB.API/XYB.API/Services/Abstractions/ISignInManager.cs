using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using XYB.Data.Entities;

namespace XYB.API.Services.Abstractions
{
    public interface ISignInManager
    {
        Task<SignInResult> CheckPasswordSignInAsync(AppUser user, string password, bool lockoutOnFailure);
    }
}
