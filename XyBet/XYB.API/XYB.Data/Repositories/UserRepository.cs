using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
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

        public async Task<AppUser> GetByUserNameAsync(string name)
        {
            return await _context.Set<AppUser>()
                .Where(u => u.NormalizedUserName.Equals(name, System.StringComparison.InvariantCultureIgnoreCase))
                .FirstOrDefaultAsync();
        }
    }
}
