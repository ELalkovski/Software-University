using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Shopping_Spree
{
    public class StartUp
    {
        public static void Main()
        {
            var peopleInfo = Console.ReadLine()
                .Split(new []{'=', ';'}, StringSplitOptions.RemoveEmptyEntries);
            var people = new List<Person>();

            for (int i = 0; i < peopleInfo.Length; i += 2)
            {
                var name = peopleInfo[i];
                var money = decimal.Parse(peopleInfo[i + 1]);
                try
                {
                    var person = new Person(name, money);
                    people.Add(person);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return;
                }
                
            }

            var productsInfo = Console.ReadLine()
                .Split(new[] { '=', ';' }, StringSplitOptions.RemoveEmptyEntries);
            var products = new List<Product>();

            for (int i = 0; i < productsInfo.Length; i += 2)
            {
                var name = productsInfo[i];
                var price = decimal.Parse(productsInfo[i + 1]);
                try
                {
                    var product = new Product(name, price);
                    products.Add(product);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return;
                }
            }

            var inputLine = Console.ReadLine();

            while (inputLine != "END")
            {
                var tokens = inputLine.Split(' ');
                var personName = tokens[0];
                var productName = tokens[1];

                if (people.Any(p => p.Name.Equals(personName)) && products.Any(p => p.Name.Equals(productName)))
                {
                    var personNeeded = people.First(p => p.Name.Equals(personName));
                    var productNeeded = products.First(p => p.Name.Equals(productName));

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
