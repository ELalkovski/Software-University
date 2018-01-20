namespace ProductsShop.App
{
    using System.IO;
    using System.Linq;
    using System.Xml.Linq;
    using Microsoft.EntityFrameworkCore;
    using Newtonsoft.Json;
    using ProductsShop.Data;

    public class StartUp
    {
        public static void Main()
        {
            using (var db = new ProductsShopDbContext())
            {
                //DatabaseInitializer.ResetDatabaseWithJsonFiles(db);
                //DatabaseInitializer.ResetDatabaseWithXmlFiles(db);
            }
        }


        //XML Exports
        //4. Users and Products
        private static void GetUsersAndProductsJsonGetUsersAndProductsXml(ProductsShopDbContext db)
        {
            var users = db.Users
                .Where(u => u.ProductsSold.Any(p => p.BuyerId != null))
                .OrderByDescending(u => u.ProductsSold.Count)
                .ThenBy(u => u.LastName)
                .Select(u => new
                {
                    u.FirstName,
                    u.LastName,
                    u.Age,
                    ProductsSold = u.ProductsSold.Select(p => new
                    {
                        p.Name,
                        p.Price
                    }).ToArray()
                })
                .ToArray();

            XDocument xmlDoc = new XDocument();
            XElement usersElement = new XElement("users", new XAttribute("count", users.Count()));

            foreach (var user in users)
            {
                XAttribute firstNameAttribute = new XAttribute("first-name", user.FirstName ?? "");
                XAttribute lastNameAttribute = new XAttribute("last-name", user.LastName);
                XAttribute ageAttribute = new XAttribute("age", user.Age ?? 0);
                XElement productsCountElement = new XElement("sold-products", new XAttribute("count", user.ProductsSold.Count()));
                XElement currUserElement = new XElement("user");
               

                if (user.FirstName != null)
                {
                    currUserElement.Add(firstNameAttribute);
                }

                currUserElement.Add(lastNameAttribute);

                if (user.Age != 0)
                {
                    currUserElement.Add(ageAttribute);
                }

                foreach (var product in user.ProductsSold)
                {
                    XElement productElement = new XElement("product");
                    XAttribute nameAttribute = new XAttribute("name", product.Name);
                    XAttribute priceAttribute = new XAttribute("price", product.Price);
                    productElement.Add(nameAttribute, priceAttribute);
                    productsCountElement.Add(productElement);
                }

                currUserElement.Add(productsCountElement);
                usersElement.Add(currUserElement);
            }

            xmlDoc.Add(usersElement);
            xmlDoc.Save("XmlExports/users-and-products.xml");
        }

        //3. Categories by Product Count
        private static void GetCategoriesByProductCountXml(ProductsShopDbContext db)
        {
            var categories = db.Categories
                .Include(c => c.CategoryProducts)
                .ThenInclude(cp => cp.Product)
                .Where(c => c.CategoryProducts.Count > 0)
                .OrderBy(c => c.CategoryProducts.Count)
                .Select(c => new
                {
                    c.Name,
                    ProductsCount = c.CategoryProducts.Count,
                    AveragePrice = c.CategoryProducts.Average(cp => cp.Product.Price),
                    Revenue = c.CategoryProducts.Sum(cp => cp.Product.Price)
                }).ToArray()
                .ToArray();

            XDocument xmlDoc = new XDocument();
            XElement categoriesRoot = new XElement("categories");

            foreach (var category in categories)
            {
                XAttribute categoryName = new XAttribute("name", category.Name);
                XElement countElement = new XElement("products-count", category.ProductsCount);
                XElement averagePriceElement = new XElement("average-price", category.AveragePrice);
                XElement revenueElement = new XElement("total-revenue", category.Revenue);

                XElement categoryElement = new XElement("category", categoryName, countElement, averagePriceElement, revenueElement);

                categoriesRoot.Add(categoryElement);
            }

            xmlDoc.Add(categoriesRoot);
            xmlDoc.Save("XmlExports/categories-by-products.xml");
        }

        //2. Sold Products
        private static void GetSuccessfullySoldProductsXml(ProductsShopDbContext db)
        {
            var sellers = db.Users
                .Where(u => u.ProductsSold.Any(p => p.BuyerId != null))
                .OrderBy(u => u.LastName)
                .ThenBy(u => u.FirstName)
                .Select(u => new
                {
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    ProductsSold = u.ProductsSold
                        .Select(p => new
                        {
                            Name = p.Name,
                            Price = p.Price
                        }).ToArray()
                });

            XElement users = new XElement("users");
            XDocument xmlDoc = new XDocument();
            

            foreach (var user in sellers)
            {
                XAttribute firstName = new XAttribute("first-name", user.FirstName ?? "");
                XAttribute lastName = new XAttribute("last-name", user.LastName);
                XElement productsSold = new XElement("sold-products");

                foreach (var product in user.ProductsSold)
                {
                    XElement productName = new XElement("name", product.Name);
                    XElement productPrice = new XElement("price", product.Price);
                    XElement productTag = new XElement("product", productName, productPrice);

                    productsSold.Add(productTag);
                }

                XElement userTag = new XElement("user", firstName, lastName, productsSold);
                users.Add(userTag);
            }

            xmlDoc.Add(users);
            xmlDoc.Save("XmlExports/users-sold-products.xml");
        }

        //1. Get Products in Range
        private static void GetProductsInRangeXml(ProductsShopDbContext db)
        {
            var productsByRange = db.Products
                .Include(p => p.Buyer)
                .Where(p => p.Price >= 1000 && p.Price <= 2000)
                .Select(p => new
                {
                    Name = p.Name,
                    Price = p.Price,
                    Buyer = p.Buyer.FirstName + " " + p.Buyer.LastName
                })
                .OrderBy(p => p.Price)
                .ToArray();

            XDocument xmlDoc = new XDocument();
            xmlDoc.Add(new XElement("products"));

            foreach (var product in productsByRange.Where(p => p.Buyer != null))
            {
                xmlDoc.Element("products").Add(new XElement("product", new XAttribute("name", product.Name), new XAttribute("price", product.Price), new XAttribute("buyer", product.Buyer)));
            }

            xmlDoc.Save("XmlExports/products-in-range.xml");
        }

        //JSON Exports
        //4. Users and Products
        private static void GetUsersAndProductsJson(ProductsShopDbContext db)
        {
            var users = db.Users
                .Where(u => u.ProductsSold.Count > 1)
                .OrderByDescending(u => u.ProductsSold.Count)
                .ThenBy(u => u.LastName)
                .Select(u => new
                {
                    u.FirstName,
                    u.LastName,
                    u.Age,
                    SoldProducts = new
                        {
                            Count = u.ProductsSold.Count,
                            Products = u.ProductsSold
                            .Select(p => new
                                {
                                    p.Name,
                                    p.Price
                                }).ToArray()
                        }
                }).ToList();

            var usersWithProducts = users
                .Select(u => new
                {
                    UsersCount = users.Count,
                    Users = users
                });

            var usersJsonString = JsonConvert.SerializeObject(usersWithProducts, Formatting.Indented);
            File.AppendAllText("JsonExports/users-and-products.json", usersJsonString);
        }

        //3. Categories by Product Count
        private static void GetCategoriesByProductCountJson(ProductsShopDbContext db)
        {
            var categories = db.Categories
                .Include(cp => cp.CategoryProducts)
                .ThenInclude(p => p.Product)
                .Where(c => c.CategoryProducts.Count > 0)
                .OrderBy(c => c.Name)
                .Select(c => new
                {
                    Category = c.Name,
                    ProductsCount = c.CategoryProducts.Count,
                    AveragePrice = c.CategoryProducts.Average(p => p.Product.Price),
                    TotalRevenue = c.CategoryProducts.Sum(p => p.Product.Price)
                }).ToArray();

            var categoriesJsonString = JsonConvert.SerializeObject(categories, Formatting.Indented);
            File.AppendAllText("JsonExports/categories-by-products.json", categoriesJsonString);
        }

        //2. Successfully Sold Products
        private static void GetSuccessfullySoldProductsJson(ProductsShopDbContext db)
        {
            var sellers = db.Users
                .Where(u => u.ProductsSold.Any(p => p.BuyerId != null))
                .OrderBy(u => u.LastName)
                .ThenBy(u => u.FirstName)
                .Select(u => new
                {
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    ProductsSold = u.ProductsSold
                        .Select(p => new
                        {
                            Name = p.Name,
                            Price = p.Price,
                            BuyerFirstName = p.Buyer.FirstName,
                            BuyerLastName = p.Buyer.LastName
                        }).ToArray()
                });

            string sellersAsJson = JsonConvert.SerializeObject(sellers, Formatting.Indented);
            File.AppendAllText("JsonExports/users-sold-products.json", sellersAsJson);
        }

        //1. Products in Range
        private static void GetProductsInRangeJson(ProductsShopDbContext db)
        {
            var productsByRange = db.Products
                .Select(p => new
                {
                    Name = p.Name,
                    Price = p.Price,
                    Seller = p.Seller.FirstName + " " + p.Seller.LastName
                })
                .Where(p => p.Price >= 500 && p.Price <= 1000)
                .OrderBy(p => p.Price)
                .ToArray();

            string productsAsJson = JsonConvert.SerializeObject(productsByRange, Formatting.Indented);
            File.AppendAllText("JsonExports/products-in-range.json", productsAsJson);
        }
    }
}
