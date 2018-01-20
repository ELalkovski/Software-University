namespace ProductsShop.App
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Xml.Linq;
    using Newtonsoft.Json;
    using ProductsShop.Data;
    using ProductsShop.Models;

    public class DatabaseInitializer
    {

        public static void ResetDatabaseWithJsonFiles(ProductsShopDbContext db)
        {
            string usersJson = File.ReadAllText("users.json");
            string productsJson = File.ReadAllText("products.json");
            string categoriesJson = File.ReadAllText("categories.json");

            db.Database.EnsureDeleted();
            db.Database.EnsureCreated();
            ImportDataFromJsonFiles(db, usersJson, productsJson, categoriesJson);
        }

        public static void ResetDatabaseWithXmlFiles(ProductsShopDbContext db)
        {
            db.Database.EnsureDeleted();
            db.Database.EnsureCreated();
            ImportdDataFromXmlFiles(db);
        }

        //XML Imports
        private static void ImportdDataFromXmlFiles(ProductsShopDbContext db)
        {
            XDocument xmlUsersDoc = XDocument.Load("users.xml");
            XDocument xmlProductsDoc = XDocument.Load("products.xml");
            XDocument xmlCategoriesDoc = XDocument.Load("categories.xml");

            IEnumerable<XElement> usersElements = xmlUsersDoc.Root?.Elements();
            IEnumerable<XElement> productsElements = xmlProductsDoc.Root?.Elements();
            IEnumerable<XElement> categoriesElements = xmlCategoriesDoc.Root?.Elements();

            List<User> usersToAdd = new List<User>();
            List<Product> productsToAdd = new List<Product>();
            List<Category> categoriesToAdd = new List<Category>();
            List<ProductCategory> productCategoriesToAdd = new List<ProductCategory>();

            // Create User objects
            foreach (var element in usersElements)
            {
                string firstName = element.Attribute("firstName")?.Value;
                string lastName = element.Attribute("lastName")?.Value;
                int? age = 0;

                if (element.Attribute("age") != null)
                {
                    age = int.Parse(element.Attribute("age").Value);
                }

                User currentUser = new User(firstName, lastName, age);
                usersToAdd.Add(currentUser);
            }

            db.Users.AddRange(usersToAdd);
            db.SaveChanges();

            // Create Category objects
            foreach (var element in categoriesElements)
            {
                string name = element.Element("name").Value;
                Category currCategory = new Category(name);

                categoriesToAdd.Add(currCategory);
            }

            db.Categories.AddRange(categoriesToAdd);
            db.SaveChanges();

            Random rand = new Random();

            // Create Product objects
            foreach (var element in productsElements)
            {
                string name = element.Element("name")?.Value;
                decimal price = decimal.Parse(element.Element("price")?.Value);
                int sellerId = rand.Next(1, db.Users.Count());
                int buyerId = rand.Next(1, db.Users.Count());

                Product currProduct = new Product(name, price, sellerId);

                if (sellerId != buyerId && (buyerId > sellerId + 4 || buyerId < sellerId - 4))
                {
                    currProduct.BuyerId = buyerId;
                }

                productsToAdd.Add(currProduct);
            }
            
            db.Products.AddRange(productsToAdd);
            db.SaveChanges();

            foreach (var product in db.Products)
            {
                int productId = product.Id;
                int categoryId = rand.Next(1, db.Categories.Count());

                ProductCategory productCategory = new ProductCategory(productId, categoryId);
                productCategoriesToAdd.Add(productCategory);
            }

            
            db.ProductCategories.AddRange(productCategoriesToAdd);
            db.SaveChanges();
        }

        //Json Imports
        private static void ImportDataFromJsonFiles(ProductsShopDbContext db, string usersJson, string productsJson, string categoriesJson)
        {
            ICollection<User> usersToAdd = JsonConvert.DeserializeObject<ICollection<User>>(usersJson);
            db.Users.AddRange(usersToAdd);
            db.SaveChanges();

            List<User> dbUsers = db.Users.ToList();
            ICollection<Product> productsToAdd = JsonConvert.DeserializeObject<ICollection<Product>>(productsJson);
            FillProductsBuyersAndSellers(productsToAdd, dbUsers);
            db.Products.AddRange(productsToAdd);
            db.SaveChanges();

            ICollection<Category> categoriesToAdd =
                JsonConvert.DeserializeObject<ICollection<Category>>(categoriesJson);
            db.Categories.AddRange(categoriesToAdd);
            db.SaveChanges();

            List<Product> dbProducts = db.Products.ToList();
            List<Category> dbCategories = db.Categories.ToList();
            ICollection<ProductCategory> productCategories = FillProductsCategories(dbProducts, dbCategories);
            db.ProductCategories.AddRange(productCategories);
            db.SaveChanges();
        }

        private static ICollection<ProductCategory> FillProductsCategories(List<Product> dbProducts, List<Category> dbCategories)
        {
            Random rand = new Random();
            ICollection<ProductCategory> productCategories = new List<ProductCategory>();

            foreach (var product in dbProducts)
            {
                int categoryId = rand.Next(1, dbCategories.Count);
                Category category = dbCategories.FirstOrDefault(c => c.Id.Equals(categoryId));

                ProductCategory productCategory = new ProductCategory(product.Id, product, categoryId, category);
                productCategories.Add(productCategory);
            }

            return productCategories;
        }

        private static void FillProductsBuyersAndSellers(ICollection<Product> productsToAdd, List<User> dbUsers)
        {
            Random rand = new Random();

            foreach (var product in productsToAdd)
            {
                int sellerId = rand.Next(1, dbUsers.Count);
                User seller = dbUsers.FirstOrDefault(u => u.Id.Equals(sellerId));

                product.SellerId = sellerId;
                product.Seller = seller;

                int buyerId = rand.Next(1, dbUsers.Count);
                User buyer = dbUsers.FirstOrDefault(u => u.Id.Equals(buyerId));

                if (buyerId != sellerId)
                {
                    product.BuyerId = buyerId;
                    product.Buyer = buyer;
                }
            }
        }
    }
}
