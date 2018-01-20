namespace P01_BillsPaymentSystem.Data.EntityConfig
{
    using Microsoft.EntityFrameworkCore;
    using P01_BillsPaymentSystem.Data.Models;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class BankAccountConfiguration : IEntityTypeConfiguration<BankAccount>
    {
        public void Configure(EntityTypeBuilder<BankAccount> builder)
        {
            builder.HasKey(ba => ba.BankAccountId);

            builder.Ignore(ba => ba.PaymentMethodId);

            builder
                .Property(ba => ba.BankName)
                .HasMaxLength(50)
                .IsUnicode();

            builder
                .Property(ba => ba.SwiftCode)
                .HasMaxLength(20)
                .IsUnicode(false);
        }
    }
}
