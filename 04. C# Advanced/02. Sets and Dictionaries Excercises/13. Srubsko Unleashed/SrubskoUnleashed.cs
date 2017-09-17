namespace _13.Srubsko_Unleashed
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SrubskoUnleashed
    {
        public static void Main()
        {
            /*
             This program recieves input on every line in format: "singer @venue ticketsPrice ticketsCount". 
              Aggregates the data by venue/town and by singer. 
             For each venue, prints the singer and the total amount of money his/her concerts have made on a separate line. 
             Venues are kept in the same order they were entered. The singers are sorted by how much money they have made in descending order.
             Finnaly prints the results on the console.
             */

            string input = Console.ReadLine();
            Dictionary<string, Dictionary<string, int>> singersDetails = new Dictionary<string, Dictionary<string, int>>();

            while (input != "End")
            {
                string[] tokens = input
                    .Split(new []{" @"}, StringSplitOptions.RemoveEmptyEntries);

                if (tokens.Length > 1)
                {
                    string singerName = tokens[0];
                    string[] otherTokens = tokens[1]
                        .Split(' ');

                    int ticketPrice = 0;
                    int ticketsBought = 0;

                    try
                    {
                        ticketPrice = int.Parse(otherTokens[otherTokens.Length - 2]);
                        ticketsBought = int.Parse(otherTokens[otherTokens.Length - 1]);
                    }
                    catch (Exception e)
                    {
                        input = Console.ReadLine();

                        continue;
                    }

                    string townName = "";

                    for (int i = 0; i < otherTokens.Length - 2; i++)
                    {
                        townName += otherTokens[i];
                        townName += " ";
                    }

                    int moneyEarned = ticketPrice * ticketsBought;

                    if (!singersDetails.ContainsKey(townName))
                    {
                        singersDetails[townName] = new Dictionary<string, int>();
                        singersDetails[townName].Add(singerName, moneyEarned);
                    }
                    else
                    {
                        if (!singersDetails[townName].ContainsKey(singerName))
                        {
                            singersDetails[townName].Add(singerName, moneyEarned);
                        }
                        else
                        {
                            singersDetails[townName][singerName] += moneyEarned;
                        }
                    }
                }
                
                input = Console.ReadLine();
            }

            foreach (var town in singersDetails)
            {
                Console.WriteLine(town.Key);

                foreach (var singer in town.Value.OrderByDescending(s => s.Value))
                {
                    Console.WriteLine($"#  {singer.Key} -> {singer.Value}");
                }
            }
        }
    }
}
