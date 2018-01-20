namespace EmployeesSystem.Data
{
    using EmployeesSystem.Models;
    using Microsoft.EntityFrameworkCore;

    public class EmployeesDbContext : DbContext
    {
        public EmployeesDbContext()
        {

        }

        public EmployeesDbContext(DbContextOptions options)
            : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ServerConfig.ConnectionString);
            }
        }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity
                    .Property(e => e.BirthDate)
                    .IsRequired(false);

                entity
                    .Property(e => e.Address)
                    .IsRequired(false);

                entity
                    .Property(e => e.FirstName)
                    .HasMaxLength(30)
                    .IsRequired();

                entity
                    .Property(e => e.LastName)
                    .HasMaxLength(30)
                    .IsRequired();
            });
        }
    }
}
