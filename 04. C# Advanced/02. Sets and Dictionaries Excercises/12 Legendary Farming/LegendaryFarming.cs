namespace _12_Legendary_Farming
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LegendaryFarming
    {
        public static void Main()
        {
            /*
             
            •	Shadowmourne – requires 250 Shards;
            •	Valanyr – requires 250 Fragments;
            •	Dragonwrath – requires 250 Motes;
            Shards, Fragments and Motes are the key materials, all else is junk. The program recieves lines of input, such as 
            2 motes 3 ores 15 stones. Keeps track of the key materials - the first that reaches the 250 ends the input. 
            At that point, prints the corresponding legendary obtained. 
            Then, prints the remaining shards, fragments, motes, ordered by quantity in descending order, each on a new line. 
            Finally, the program prints the collected junk items, in alphabetical order.
             */

            string input = Console.ReadLine();

            SortedDictionary<string, int> resources = new SortedDictionary<string, int>();
            SortedDictionary<string, int> junk = new SortedDictionary<string, int>();

            resources.Add("shards", 0);
            resources.Add("fragments", 0);
            resources.Add("motes", 0);

            while (true)
            {
                string[] tokens = input
                    .Split(' ');

                for (int i = 0; i < tokens.Length; i += 2)
                {
                    int materialQuantity = int.Parse(tokens[i]);
                    string currMaterial = tokens[i + 1].ToLower();

                    if (currMaterial != "shards" && currMaterial != "fragments" && currMaterial != "motes")
                    {
                        if (!junk.ContainsKey(currMaterial))
                        {
                            junk.Add(currMaterial, materialQuantity);
                        }
                        else
                        {
                            junk[currMaterial] += materialQuantity;
                        }
                    }
                    else
                    {
                        resources[currMaterial] += materialQuantity;
                    }

                    if (resources.ContainsKey("shards") && resources["shards"] >= 250)
                    {
                        Console.WriteLine("Shadowmourne obtained!");

                        int leftOvers = resources["shards"];
                        resources["shards"] = (leftOvers - 250);
                        PrintResults(resources, junk);

                        return;
                    }
                    if (resources.ContainsKey("fragments") && resources["fragments"] >= 250)
                    {
                        Console.WriteLine("Valanyr obtained!");

                        int leftOvers = resources["fragments"];
                        resources["fragments"] = (leftOvers - 250);
                        PrintResults(resources, junk);

                        return;
                    }
                    if (resources.ContainsKey("motes") && resources["motes"] >= 250)
                    {
                        Console.WriteLine("Dragonwrath obtained!");

                        int leftOvers = resources["motes"];
                        resources["motes"] = (leftOvers - 250);
                        PrintResults(resources, junk);

                        return;
                    }
                }

                input = Console.ReadLine();
            }
        }

        private static void PrintResults(SortedDictionary<string, int> resources, SortedDictionary<string, int> junk)
        {
            foreach (var material in resources.OrderByDescending(r => r.Value))
            {
                Console.WriteLine($"{material.Key}: {material.Value}");
            }
            foreach (var material in junk)
            {
                Console.WriteLine($"{material.Key}: {material.Value}");
            }
        }
    }
}
