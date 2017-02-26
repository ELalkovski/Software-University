namespace _4
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;

    public class HornetArmada
    {
        public class Legion
        {
            public Dictionary<string, long> SoldierType { get; set; }

            public string Name { get; set; }

            public long SoldierCount { get; set; }

            public int LastActivity { get; set; }

        }

        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var allLegions = new Dictionary<string, Legion>();


            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split(new[] { '=', '-', '>', ':', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                var currLegion = new Legion();
                var currSoldierType = new Dictionary<string, long>();
                var activity = int.Parse(input[0]);
                var name = input[1];
                var soldierType = input[2];
                var count = long.Parse(input[3]);

                currSoldierType.Add(soldierType, count);
                currLegion.LastActivity = activity;
                currLegion.Name = name;
                currLegion.SoldierCount = count;
                currLegion.SoldierType = currSoldierType;

                if (!allLegions.ContainsKey(name))
                {
                    allLegions.Add(name, currLegion);

                }
                else
                {
                    if (!allLegions[name].SoldierType.ContainsKey(soldierType))
                    {
                        allLegions[name].SoldierType.Add(soldierType, count);
                    }
                    else
                    {
                        allLegions[name].SoldierType[soldierType] += count;
                        allLegions[name].SoldierCount += count;
                    }
                    if (activity > allLegions[name].LastActivity)
                    {
                        allLegions[name].LastActivity = activity;
                    }
                }
            }

            var command = Console.ReadLine()
                .Split('\\');

            if (command.Length > 1)
            {
                var lastActivity = int.Parse(command[0]);
                var soldierType = command[1];

                foreach (var legion in allLegions.OrderByDescending(x => x.Value.SoldierType[soldierType]))
                {
                    if (legion.Value.LastActivity < lastActivity)
                    {
                        Console.WriteLine($"{legion.Key} -> {legion.Value.SoldierType[soldierType]}");
                    }
                }
            }
            else
            {
                foreach (var legion in allLegions.OrderByDescending(a => a.Value.LastActivity))
                {
                    if (legion.Value.SoldierType.ContainsKey(command[0]))
                    {
                        Console.WriteLine($"{legion.Value.LastActivity} : {legion.Key}");
                    }
                }
            }
        }
    }
}
