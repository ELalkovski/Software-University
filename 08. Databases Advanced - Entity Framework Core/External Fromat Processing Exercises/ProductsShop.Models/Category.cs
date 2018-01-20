namespace ProductsShop.Models
{
    using System.Collections.Generic;

    public class Category
    {
        public Category()
        {
            this.CategoryProducts = new List<ProductCategory>();
        }

        public Category(string name)
        {
            this.Name = name;
            this.CategoryProducts = new List<ProductCategory>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<ProductCategory> CategoryProducts { get; set; }
    }
}
