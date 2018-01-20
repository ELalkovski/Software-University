namespace ProductsShop.Models
{
    using System.Collections.Generic;

    public class Product
    {
        public Product()
        {
            this.ProductCategories = new List<ProductCategory>();
        }

        public Product(string name, decimal price, int sellerId)
        {
            this.Name = name;
            this.Price = price;
            this.SellerId = sellerId;
            this.ProductCategories = new List<ProductCategory>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int? BuyerId { get; set; }
        public User Buyer { get; set; }

        public int? SellerId { get; set; }
        public User Seller { get; set; }

        public ICollection<ProductCategory> ProductCategories { get; set; }
    }
}
