namespace ProductsShop.Models
{
    using System.Collections.Generic;

    public class User
    {
        public User()
        {
            
        }

        public User(string firstName, string lastName, int? age)
        {
            this.Age = age;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public int Id { get; set; }

        public int? Age { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public ICollection<Product> ProductsSold { get; set; }

        public ICollection<Product> ProductsBought { get; set; }
    }
}
