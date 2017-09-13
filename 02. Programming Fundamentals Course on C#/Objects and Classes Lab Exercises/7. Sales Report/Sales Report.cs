namespace _7.Sales_Report
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class SalesReport
    {
        public static Sale ReadSale()
        {
            var input = Console.ReadLine().Split(' ');

            return new Sale()
            {
                Town = input[0],
                Price = decimal.Parse(input[2]),
                Quantity = decimal.Parse(input[3])
            };
        }

        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var salesByTown = new SortedDictionary<string, decimal>();

            var sales = new Sale[n];

            for (int i = 0; i < sales.Length; i++)
            {
                sales[i] = ReadSale();
            }

            for (int i = 0; i < n; i++)
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
    }
}
