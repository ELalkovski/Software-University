using System;
using System.Collections.Generic;

namespace _04.Shopping_Spree
{
    public class Person
    {
        private string name;
        private decimal money;
        private List<Product> products;

        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            this.products = new List<Product>();
        }

        public string Name
        {
            get { return this.name; }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException($"{nameof(Name)} cannot be empty");
                }

                this.name = value;
            }
        }

        public decimal Money
        {
            get { return this.money; }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException($"{nameof(Money)} cannot be negative");
                }

                this.money = value;
            }
        }

        public IList<Product> Products
        {
            get { return this.products.AsReadOnly(); }
        }

        public void TryToBuyProduct(Product product)
        {
            if (this.money - product.Price >= 0)
            {
                Console.WriteLine($"{this.Name} bought {product.Name}");
                this.products.Add(product);
                this.Money -= product.Price;
            }
            else
            {
                Console.WriteLine($"{this.Name} can't afford {product.Name}");
            }
        }
    }
}
