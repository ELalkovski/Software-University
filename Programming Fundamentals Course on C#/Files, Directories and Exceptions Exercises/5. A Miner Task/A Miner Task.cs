using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace _5.A_Miner_Task
{
    class MinerTask
    {
        public static void Main()
        {
            var input = File.ReadAllLines("Input.txt");
            var resourcesCount = new Dictionary<string, int>();

            var resource = new List<string>();
            var quantity = new List<int>();
            var lineCounter = 0;

            foreach (var item in input)
            {
                if (item == "stop")
                {
                    break;
                }

                if (lineCounter % 2 == 0 || lineCounter == 0)
                {
                    resource.Add(item);
                }
                else
                {
                    quantity.Add(int.Parse(item));
                }

                lineCounter++;
            }

            for (int i = 0; i < resource.Count; i++)
            {
                if (!resourcesCount.ContainsKey(resource[i]))
                {
                    resourcesCount.Add(resource[i], 0);
                }

                resourcesCount[resource[i]] += quantity[i];
            }

            foreach (var item in resourcesCount)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
                File.AppendAllText("output.txt",item.Key + " -> " + item.Value.ToString() + Environment.NewLine);
            }
        }
    }
}
