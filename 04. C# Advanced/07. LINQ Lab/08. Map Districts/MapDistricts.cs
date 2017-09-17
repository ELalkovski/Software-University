namespace _08.Map_Districts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MapDistricts
    {
        public static void Main()
        {
            string[] cities = Console.ReadLine()
                .Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries);
            long boundry = long.Parse(Console.ReadLine());

            Dictionary<string, List<long>> populations = new Dictionary<string, List<long>>();

            foreach (var city in cities)
            {
                string[] tokens = city.Split(':');
                string cityName = tokens[0];
                long population = long.Parse(tokens[1]);

                if (!populations.ContainsKey(cityName))
                {
                    populations.Add(cityName, new List<long>());
                }

                populations[cityName].Add(population);
            }


            foreach (var city in populations.Where(c => c.Value.Sum() > boundry).OrderByDescending(p => p.Value.Sum()))
            {
                Console.Write($"{city.Key}: ");
                Console.Write(string.Join(" ", city.Value.OrderByDescending(p => p).Take(5)));
                Console.WriteLine();
            }
        }
    }
}
