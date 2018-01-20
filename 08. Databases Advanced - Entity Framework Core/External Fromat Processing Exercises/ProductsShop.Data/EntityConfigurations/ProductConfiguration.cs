namespace ProductsShop.Data.EntityConfigurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using ProductsShop.Models;

    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder
                .HasKey(p => p.Id);

            builder
                .Property(p => p.BuyerId)
                .IsRequired(false);

            builder
                .HasOne(p => p.Buyer)
                .WithMany(b => b.ProductsBought)
                .HasForeignKey(p => p.BuyerId)
                .HasConstraintName("FK_Product_Buyer_Id");

            builder
                .HasOne(p => p.Seller)
                .WithMany(b => b.ProductsSold)
                .HasForeignKey(p => p.SellerId)
                .HasConstraintName("FK_Product_Seller_Id")
                .IsRequired(false);
        }
    }
}
