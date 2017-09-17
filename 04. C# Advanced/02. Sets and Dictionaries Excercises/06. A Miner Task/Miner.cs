namespace _06.A_Miner_Task
{
    using System;
    using System.Collections.Generic;

    public class Miner
    {
        public static void Main()
        {
            /*
            
            This program recieves a sequence of strings, each on a new line. 
            Every odd line on the console is representing a resource (e.g. Gold, Silver, Copper, and so on) , and every even – quantity.
            Keeps reading lines from the console until it receives the command "stop". 
            Prints the resources and their quantities in format:   “{resource} –> {quantity}”            
             */

            string input = Console.ReadLine();
            Dictionary<string, int> resourcesCounts = new Dictionary<string, int>();
            int counter = 1;
            string prevResource = "";

            while (input != "stop")
            {
                if (counter % 2 == 0)
                {
                    int quantity = int.Parse(input);
                    resourcesCounts[prevResource] += quantity;
                }
                else
                {
                    if (!resourcesCounts.ContainsKey(input))
                    {
                        resourcesCounts.Add(input, 0);
                    }

                    prevResource = input;
                }

                counter++;
                input = Console.ReadLine();
            }

            foreach (var resource in resourcesCounts)
            {
                Console.WriteLine($"{resource.Key} -> {resource.Value}");
            }
        }
    }
}
