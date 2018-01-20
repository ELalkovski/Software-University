namespace BusTicketSystem.Data
{
    using BusTicketSystem.Data.Configuration;
    using BusTicketSystem.Models;
    using Microsoft.EntityFrameworkCore;

    public class BusStationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ServerConfig.ConnectionString);
            }
        }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<BankAccount> BankAccounts { get; set; }

        public DbSet<Town> Towns { get; set; }

        public DbSet<BusCompany> BusCompanies { get; set; }

        public DbSet<Ticket> Tickets { get; set; }

        public DbSet<BusStation> BusStations { get; set; }

        public DbSet<Review> Reviews { get; set; }

        public DbSet<Trip> Trips { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BankAccountConfiguration());

            modelBuilder.ApplyConfiguration(new TownConfiguration());

            modelBuilder.ApplyConfiguration(new BusCompanyConfiguration());

            modelBuilder.ApplyConfiguration(new TicketConfiguration());

            modelBuilder.ApplyConfiguration(new CustomerConfiguration());

            modelBuilder.ApplyConfiguration(new BusStationConfiguration());

            modelBuilder.ApplyConfiguration(new ReviewConfiguration());

            modelBuilder.ApplyConfiguration(new TripConfiguration());
        }
    }
}
