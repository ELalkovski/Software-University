namespace _04.Shopping_Spree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string[] peopleInfo = Console.ReadLine()
                .Split(new []{'=', ';'}, StringSplitOptions.RemoveEmptyEntries);

            List<Person> people = new List<Person>();

            for (int i = 0; i < peopleInfo.Length; i += 2)
            {
                string name = peopleInfo[i];
                decimal money = decimal.Parse(peopleInfo[i + 1]);

                try
                {
                    Person person = new Person(name, money);
                    people.Add(person);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);

                    return;
                }
                
            }

            string[] productsInfo = Console.ReadLine()
                .Split(new[] { '=', ';' }, StringSplitOptions.RemoveEmptyEntries);

            List<Product> products = new List<Product>();

            for (int i = 0; i < productsInfo.Length; i += 2)
            {
                string name = productsInfo[i];
                decimal price = decimal.Parse(productsInfo[i + 1]);
                try
                {
                    Product product = new Product(name, price);
                    products.Add(product);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);

                    return;
                }
            }

            string inputLine = Console.ReadLine();

            while (inputLine != "END")
            {
                string[] tokens = inputLine.Split(' ');
                string personName = tokens[0];
                string productName = tokens[1];

                if (people.Any(p => p.Name.Equals(personName)) && products.Any(p => p.Name.Equals(productName)))
                {
                    Person personNeeded = people.First(p => p.Name.Equals(personName));
                    Product productNeeded = products.First(p => p.Name.Equals(productName));

                    personNeeded.TryToBuyProduct(productNeeded);
                }

                inputLine = Console.ReadLine();
            }

            foreach (var person in people)
            {
                if (person.Products.Count > 0)
                {
                    Console.WriteLine($"{person.Name} - {string.Join(", ", person.Products.Select(p => p.Name))}");
                }
                else
                {
                    Console.WriteLine($"{person.Name} - Nothing bought");
                }
            }
        }
    }
}
