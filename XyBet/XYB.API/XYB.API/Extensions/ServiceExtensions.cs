using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using XYB.Data;
using XYB.Data.Entities;

namespace XYB.API.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddIdentityContext(this IServiceCollection services)
        {
            services.AddIdentityCore<AppUser>(opt =>
            {
                opt.Password.RequireNonAlphanumeric = false;
            })
                .AddRoles<AppRole>()
                .AddRoleManager<RoleManager<AppRole>>()
                .AddSignInManager<SignInManager<AppUser>>()
                .AddRoleValidator<RoleValidator<AppRole>>()
                .AddEntityFrameworkStores<ApplicationContext>();

            return services;
        }
    }
}
