namespace BusTicketSystem.Data.Configuration
{
    using BusTicketSystem.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class TripConfiguration : IEntityTypeConfiguration<Trip>
    {
        public void Configure(EntityTypeBuilder<Trip> builder)
        {
            builder.HasKey(t => t.Id);

            builder
                .HasOne(t => t.OriginBusStation)
                .WithMany(bs => bs.Departures)
                .HasForeignKey(t => t.OriginBusStationId);

            builder
                .HasOne(t => t.DestinationBusStation)
                .WithMany(bs => bs.Arrivals)
                .HasForeignKey(t => t.DestinationBusStationId);

        }
    }
}
