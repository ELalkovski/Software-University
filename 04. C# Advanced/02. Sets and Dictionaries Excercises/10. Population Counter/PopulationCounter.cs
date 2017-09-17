namespace _10.Population_Counter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PopulationCounter
    {
        public static void Main()
        {
            /*
             This program recieves, on each input line, data in format: "city|country|population".
             Aggregates the data by country and by city and prints it on the console. 
             For each country, prints its total population and on separate lines the data for each of its cities. 
             Countries are ordered by their total population in descending order and within each country,
             the cities are ordered by the same criterion. 
             */

            string input = Console.ReadLine();
            Dictionary<string, Dictionary<string, long>> countries = new Dictionary<string, Dictionary<string, long>>();

            while (input != "report")
            {
                string[] tokens = input
                    .Split('|');

                string city = tokens[0];
                string currCountry = tokens[1];
                long population = long.Parse(tokens[2]);

                if (!countries.ContainsKey(currCountry))
                {
                    countries[currCountry] = new Dictionary<string, long>();
                    countries[currCountry].Add(city, population);
                }
                else
                {
                    if (!countries[currCountry].ContainsKey(city))
                    {
                        countries[currCountry].Add(city, population);
                    }
                    else
                    {
                        countries[currCountry][city] += population;
                    }
                }

                input = Console.ReadLine();
            }

            foreach (KeyValuePair<string, Dictionary<string, long>> country in countries.OrderByDescending(c => c.Value.Sum(p => p.Value)))
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value.Sum(p => p.Value)})");

                foreach (var city in country.Value.OrderByDescending(c => c.Value))
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }

        }
    }
}
