using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using XYB.API.Mapping;
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

        public static IServiceCollection AddAutoMapping(this IServiceCollection services)
        {
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });

            services.AddSingleton(mapperConfig.CreateMapper() as IMapper);

            return services;
        }
    }
}
