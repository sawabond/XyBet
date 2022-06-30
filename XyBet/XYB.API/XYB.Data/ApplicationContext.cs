using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using XYB.Data.Entities;

namespace XYB.Data
{
    public class ApplicationContext : IdentityDbContext
        <
        AppUser,
        AppRole,
        int,
        IdentityUserClaim<int>,
        AppUserRole,
        IdentityUserLogin<int>,
        IdentityRoleClaim<int>,
        IdentityUserToken<int>
        >
    {
        public ApplicationContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Team> Teams { get; set; }

        public DbSet<Player> Players { get; set; }

        public DbSet<Payment> Payments { get; set; }

        public DbSet<Game> Games { get; set; }

        public DbSet<GameMatch> GameMatches { get; set; }

        public DbSet<Bet> Bets { get; set; }
    }
}