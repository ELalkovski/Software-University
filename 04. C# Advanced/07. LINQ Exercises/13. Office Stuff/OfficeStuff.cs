using System;
using System.Collections.Generic;
using System.Linq;

namespace _13.Office_Stuff
{
    public class OfficeStuff
    {
        public static void Main()
        {
            var inputCount = int.Parse(Console.ReadLine());
            var companiesAndTheirProducts = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < inputCount; i++)
            {
                var currLine = Console.ReadLine()
                    .Split(new []{' ', '|', '-'}, StringSplitOptions.RemoveEmptyEntries);

                var company = currLine[0];
                var amount = int.Parse(currLine[1]);
                var product = currLine[2];

                if (!companiesAndTheirProducts.ContainsKey(company))
                {
                    companiesAndTheirProducts.Add(company, new Dictionary<string, int>());
                    companiesAndTheirProducts[company].Add(product, amount);
                }
                else
                {
                    if (!companiesAndTheirProducts[company].ContainsKey(product))
                    {
                        companiesAndTheirProducts[company].Add(product, 0);
                    }

                    companiesAndTheirProducts[company][product] += amount;
                }
            }

            foreach (var company in companiesAndTheirProducts.OrderBy(c => c.Key))
            {
                Console.Write($"{company.Key}: ");
                var counter = 0;

                foreach (var product in company.Value)
                {
                    Console.Write($"{product.Key}-{product.Value}");
                    if (counter < company.Value.Count - 1)
                    {
                        Console.Write(", ");
                    }
                    counter++;
                }
                Console.WriteLine();
            }
        }
    }
}
