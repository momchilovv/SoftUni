using Microsoft.EntityFrameworkCore;
using P02_FootballBetting.Data.Models;

namespace P02_FootballBetting.Data
{
    public class FootballBettingContext : DbContext
    {
        public FootballBettingContext() { }

        public FootballBettingContext(DbContextOptions<FootballBettingContext> options) : base(options) { }

        public DbSet<Team> Teams { get; set; } = null!;

        public DbSet<Color> Colors { get; set; } = null!;

        public DbSet<Town> Towns { get; set; } = null!;

        public DbSet<Country> Countries { get; set; } = null!;

        public DbSet<Player> Players { get; set; } = null!;

        public DbSet<Position> Positions { get; set; } = null!;

        public DbSet<PlayerStatistic> PlayersStatistics { get; set; } = null!;

        public DbSet<Game> Games { get; set; } = null!;

        public DbSet<Bet> Bets { get; set; } = null!;

        public DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.,1433;Database=FootballBetting;User Id=sa;Password=DEFINITELYNOTMYPASSWORD");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PlayerStatistic>().HasKey(pk => new { pk.PlayerId, pk.GameId });

            modelBuilder.Entity<Team>(entity =>
            {
                entity.HasOne(p => p.PrimaryKitColor)
                .WithMany(p => p.PrimaryKitTeams)
                .HasForeignKey(p => p.PrimaryKitColorId)
                .OnDelete(DeleteBehavior.NoAction);

                entity.HasOne(s => s.SecondaryKitColor)
                .WithMany(s => s.SecondaryKitTeams)
                .HasForeignKey(s => s.SecondaryKitColorId)
                .OnDelete(DeleteBehavior.NoAction);
            });

            modelBuilder.Entity<Game>(entity =>
            {
                entity.HasOne(h => h.HomeTeam)
                .WithMany(h => h.HomeGames)
                .HasForeignKey(h => h.HomeTeamId)
                .OnDelete(DeleteBehavior.NoAction);

                entity.HasOne(a => a.AwayTeam)
                .WithMany(a => a.AwayGames)
                .HasForeignKey(a => a.AwayTeamId)
                .OnDelete(DeleteBehavior.NoAction);
            });
        }
    }
}