using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Map_Districts
{
    public class MapDistricts
    {
        public static void Main()
        {
            var cities = Console.ReadLine()
                .Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries);

            var boundry = long.Parse(Console.ReadLine());

            var populations = new Dictionary<string, List<long>>();

            foreach (var city in cities)
            {
                var tokens = city.Split(':');
                var cityName = tokens[0];
                var population = long.Parse(tokens[1]);

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
