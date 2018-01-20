namespace BusTicketSystem.Data.Configuration
{
    using BusTicketSystem.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class BankAccountConfiguration : IEntityTypeConfiguration<BankAccount>
    {
        public void Configure(EntityTypeBuilder<BankAccount> builder)
        {
            builder.HasKey(ba => ba.Id);

            builder.Property(ba => ba.AccountNumber)
                .HasMaxLength(10);

            builder.HasOne(ba => ba.Customer)
                .WithOne(c => c.BankAccount)
                .HasForeignKey<BankAccount>(ba => ba.CustomerId);
        }
    }
}
