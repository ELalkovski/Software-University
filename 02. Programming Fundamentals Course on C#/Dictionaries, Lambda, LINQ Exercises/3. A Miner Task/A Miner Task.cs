namespace _3.A_Miner_Task
{
    using System;
    using System.Collections.Generic;

    public class MinerTask
    {
        public static void Main()
        {
            Dictionary<string, int> resources = new Dictionary<string, int>();
            string resourceKind = Console.ReadLine();
            
            AddResources(resources, resourceKind);
            PrintResources(resources);
        }

        public static void AddResources(Dictionary<string, int> resources, string resourceKind)
        {
            while (!resourceKind.Equals("stop"))
            {
                int quantity = int.Parse(Console.ReadLine());

                if (resources.ContainsKey(resourceKind))
                {
                    resources[resourceKind] += quantity;
                }
                else
                {
                    resources.Add(resourceKind, quantity);
                }

                resourceKind = Console.ReadLine();
            }
        }

        public static void PrintResources(Dictionary<string, int> resources)
        {
            foreach (var resource in resources)
            {
                Console.WriteLine("{0} -> {1}", resource.Key, resource.Value);
            }
        }
    }
}
