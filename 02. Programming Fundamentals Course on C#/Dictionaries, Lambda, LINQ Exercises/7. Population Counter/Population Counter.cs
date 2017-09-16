namespace _7.Population_Counter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PopulationCounter
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            Dictionary<string, Dictionary<string, long>> countryPopulations = new Dictionary<string, Dictionary<string, long>>();

            while (input != "report")
            {
                List<string> pieces = input.Split('|').ToList();
                string city = pieces[0];
                string country = pieces[1];
                long peopleCount = long.Parse(pieces[2]);
                Dictionary<string, long> cityPopulation = new Dictionary<string, long>();

                if (!countryPopulations.ContainsKey(country))
                {
                    cityPopulation[city] = peopleCount;
                    countryPopulations[country] = cityPopulation;
                }
                else
                {
                    cityPopulation = countryPopulations[country];

                    if (cityPopulation.ContainsKey(city))
                    {
                        cityPopulation[city] += peopleCount;
                    }
                    else
                    {
                        cityPopulation.Add(city, peopleCount);
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var state in countryPopulations.OrderByDescending(x => x.Value.Sum(y => y.Value)))
            {
                List<long> sumOfTowns = state.Value.Select(x => x.Value).ToList();

                Console.WriteLine("{0} (total population: {1})", state.Key, sumOfTowns.Sum());
                Console.Write($"=>{string.Join("=>", state.Value.OrderByDescending(x => x.Value).Select(x => $"{x.Key}: {x.Value}" + Environment.NewLine))}");
            }
        }
    }
}
