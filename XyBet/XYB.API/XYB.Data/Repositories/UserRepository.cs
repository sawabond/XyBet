using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using XYB.Data.Abstractions;
using XYB.Data.Entities;

namespace XYB.Data.Repositories
{
    public class UserRepository : Repository<AppUser>, IUserRepository
    {
        public UserRepository(
            IdentityDbContext
        <
        AppUser,
        AppRole,
        int,
        IdentityUserClaim<int>,
        AppUserRole,
        IdentityUserLogin<int>,
        IdentityRoleClaim<int>,
        IdentityUserToken<int>
        > context
            ) : base(context)
        {

        }
    }
}
