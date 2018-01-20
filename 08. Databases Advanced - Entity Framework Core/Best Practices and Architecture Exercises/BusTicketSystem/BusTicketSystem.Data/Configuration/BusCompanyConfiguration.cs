namespace BusTicketSystem.Data.Configuration
{
    using BusTicketSystem.Models;
    using Microsoft.EntityFrameworkCore;
    using System;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class BusCompanyConfiguration : IEntityTypeConfiguration<BusCompany>
    {
        public void Configure(EntityTypeBuilder<BusCompany> builder)
        {
            builder.HasKey(bc => bc.Id);

            builder
                .Property(bc => bc.Name)
                .HasMaxLength(50);

            builder
                .Property(bc => bc.Nationality)
                .HasMaxLength(50);

            builder
                .HasMany(bc => bc.Reviews)
                .WithOne(r => r.BusCompany)
                .HasForeignKey(r => r.BusCompanyId);

            builder
                .HasMany(bc => bc.Trips)
                .WithOne(t => t.BusCompany)
                .HasForeignKey(t => t.BusCompanyId);
        }
    }
}
