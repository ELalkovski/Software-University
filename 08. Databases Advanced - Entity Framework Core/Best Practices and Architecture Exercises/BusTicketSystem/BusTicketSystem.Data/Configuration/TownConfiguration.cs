namespace BusTicketSystem.Data.Configuration
{
    using BusTicketSystem.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class TownConfiguration : IEntityTypeConfiguration<Town>
    {
        public void Configure(EntityTypeBuilder<Town> builder)
        {
            builder.HasKey(t => t.Id);
            
            builder
                .Property(t => t.Name)
                .HasMaxLength(50);

            builder
                .Property(t => t.Country)
                .HasMaxLength(30);

            builder
                .HasMany(t => t.BusStations)
                .WithOne(bs => bs.Town)
                .HasForeignKey(bs => bs.TownId);
        }
    }
}
