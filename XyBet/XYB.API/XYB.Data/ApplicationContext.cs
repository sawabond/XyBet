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

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder
                .Entity<AppUser>()
                .HasMany(ur => ur.Payments)
                .WithOne(p => p.User)
                .HasForeignKey(ur => ur.Id)
                .IsRequired();

            builder
                 .Entity<AppUser>()
                 .HasMany(ur => ur.Bets)
                 .WithOne(p => p.User)
                 .HasForeignKey(ur => ur.Id)
                 .IsRequired();

            builder
                .Entity<Game>()
                .HasMany(g => g.Teams)
                .WithOne(t => t.Game)
                .HasForeignKey(t => t.Id)
                .IsRequired();

            builder
                .Entity<Game>()
                .HasMany(g => g.GameMatches)
                .WithOne(t => t.Game)
                .HasForeignKey(t => t.Id)
                .IsRequired();

            builder
                 .Entity<Team>()
                 .HasMany(t => t.GameMatches)
                 .WithOne(gm => gm.FirstTeam)
                 .HasForeignKey(gm => gm.Id)
                 .IsRequired();

            builder
                 .Entity<Team>()
                 .HasMany(t => t.Players)
                 .WithOne(p => p.CurrentTeam)
                 .HasForeignKey(gm => gm.Id)
                 .IsRequired();
        }
    }
}