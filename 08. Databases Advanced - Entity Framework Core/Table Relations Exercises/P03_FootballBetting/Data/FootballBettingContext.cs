namespace P03_FootballBetting.Data
{
    using Microsoft.EntityFrameworkCore;
    using P03_FootballBetting.Data.Models;

    public class FootballBettingContext : DbContext
    {
        public FootballBettingContext()
        {
        }

        public FootballBettingContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Bet> Bets { get; set; }

        public DbSet<Color> Colors { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Town> Towns { get; set; }

        public DbSet<Game> Games { get; set; }

        public DbSet<Player> Players { get; set; }

        public DbSet<Position> Positions { get; set; }

        public DbSet<Team> Teams { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<PlayerStatistic> PlayerStatistics { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Configuration.ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Color>(entity =>
            {

                entity
                    .HasKey(c => c.ColorId);

                entity
                    .HasMany(c => c.PrimaryKitTeams)
                    .WithOne(t => t.PrimaryKitColor)
                    .HasForeignKey(c => c.PrimaryKitColorId);

                entity
                    .HasMany(c => c.SecondaryKitTeams)
                    .WithOne(t => t.SecondaryKitColor)
                    .HasForeignKey(t => t.SecondaryKitColorId);
            });

            modelBuilder.Entity<Town>(entity =>
            {

                entity
                    .HasKey(t => t.TownId);

                entity
                    .HasMany(tw => tw.Teams)
                    .WithOne(t => t.Town)
                    .HasForeignKey(t => t.TownId);
            });

            modelBuilder.Entity<Team>(entity =>
            {

                entity
                    .HasKey(t => t.TeamId);

                entity
                    .HasMany(t => t.HomeGames)
                    .WithOne(hg => hg.HomeTeam)
                    .HasForeignKey(hg => hg.HomeTeamId);

                entity
                    .HasMany(t => t.AwayGames)
                    .WithOne(ag => ag.AwayTeam)
                    .HasForeignKey(ag => ag.AwayTeamId);

                entity
                    .HasMany(t => t.Players)
                    .WithOne(p => p.Team)
                    .HasForeignKey(p => p.TeamId);
            });

            modelBuilder.Entity<Country>(entity =>
            {

                entity
                    .HasKey(c => c.CountryId);

                entity
                    .HasMany(c => c.Towns)
                    .WithOne(t => t.Country)
                    .HasForeignKey(t => t.CountryId);
            });

            modelBuilder.Entity<Position>(entity =>
            {
                entity
                    .HasKey(p => p.PositionId);

                entity
                    .HasMany(pos => pos.Players)
                    .WithOne(p => p.Position)
                    .HasForeignKey(p => p.PositionId);
            });

            modelBuilder.Entity<PlayerStatistic>(entity =>
            {
                entity
                    .HasKey(ps => new {ps.PlayerId, ps.GameId});

                entity
                    .HasOne(ps => ps.Game)
                    .WithMany(g => g.PlayerStatistics)
                    .HasForeignKey(ps => ps.GameId);

                entity
                    .HasOne(ps => ps.Player)
                    .WithMany(p => p.PlayerStatistics)
                    .HasForeignKey(ps => ps.PlayerId);
            });

            modelBuilder.Entity<Bet>(entity =>
            {
                entity
                    .HasKey(b => b.BetId);

                entity
                    .Property(b => b.Prediction)
                    .IsRequired();
            });

            modelBuilder.Entity<Game>(entity =>
            {
                entity
                    .HasKey(g => g.GameId);

                entity
                    .HasMany(g => g.Bets)
                    .WithOne(b => b.Game)
                    .HasForeignKey(b => b.GameId);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity
                    .HasKey(u => u.UserId);

                entity
                    .HasMany(u => u.Bets)
                    .WithOne(b => b.User)
                    .HasForeignKey(b => b.UserId);
            });

            modelBuilder.Entity<Player>(entity =>
            {
                entity
                    .HasKey(p => p.PlayerId);
            });
        }
    }
}
