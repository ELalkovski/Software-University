namespace ProductsShop.Models
{
    public class ProductCategory
    {
        public ProductCategory()
        {
            
        }

        public ProductCategory(int productId, Product product, int categoryId, Category category)
        {
            this.ProductId = productId;
            this.Product = product;
            this.CategoryId = categoryId;
            this.Category = category;
        }

        public ProductCategory(int productId, int categoryId)
        {
            this.ProductId = productId;
            this.CategoryId = categoryId;
        }

        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
