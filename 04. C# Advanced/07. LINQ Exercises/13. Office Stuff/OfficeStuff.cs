namespace _13.Office_Stuff
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class OfficeStuff
    {
        public static void Main()
        {
            int inputCount = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> companiesAndTheirProducts = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < inputCount; i++)
            {
                string[] currLine = Console.ReadLine()
                    .Split(new []{' ', '|', '-'}, StringSplitOptions.RemoveEmptyEntries);

                string company = currLine[0];
                int amount = int.Parse(currLine[1]);
                string product = currLine[2];

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

                int counter = 0;

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
