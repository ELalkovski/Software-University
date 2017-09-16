namespace _7.Sales_Report
{
    using System;
    using System.Collections.Generic;

    public class SalesReport
    {
        public static void Main()
        {
            int linesCount = int.Parse(Console.ReadLine());
            SortedDictionary<string, decimal> salesByTown = new SortedDictionary<string, decimal>();
            Sale[] sales = new Sale[linesCount];

            for (int i = 0; i < sales.Length; i++)
            {
                sales[i] = ReadSale();
            }

            for (int i = 0; i < linesCount; i++)
            {
                if (!salesByTown.ContainsKey(sales[i].Town))
                {
                    salesByTown.Add(sales[i].Town, 0);
                }

                salesByTown[sales[i].Town] += sales[i].Price * sales[i].Quantity;
            }

            foreach (var town in salesByTown)
            {
                Console.WriteLine("{0} -> {1:f2}", town.Key, town.Value);
            }
        }

        private static Sale ReadSale()
        {
            string[] input = Console.ReadLine().Split(' ');

            return new Sale()
            {
                Town = input[0],
                Price = decimal.Parse(input[2]),
                Quantity = decimal.Parse(input[3])
            };
        }
    }
}
