namespace _14.Dragon_Army
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DragonArmy
    {
        public static void Main()
        {
            int inputCount = int.Parse(Console.ReadLine());
            Dictionary<string, SortedDictionary<string, List<decimal>>> allDragons = new Dictionary<string, SortedDictionary<string,List<decimal>>>();

            for (int i = 0; i < inputCount; i++)
            {
                string[] currInput = Console.ReadLine()
                    .Split(' ');

                string type = currInput[0];
                string name = currInput[1];
                decimal damage = 0m;
                decimal health = 0m;
                decimal armor = 0m;
                
                try
                {
                    damage = decimal.Parse(currInput[2]);
                }
                catch (Exception)
                {
                    damage = 45;
                }

                try
                {
                    health = decimal.Parse(currInput[3]);
                }
                catch (Exception)
                {
                    health = 250;
                }

                try
                {
                    armor = decimal.Parse(currInput[4]);
                }
                catch (Exception)
                {
                    armor = 10;
                }

                SortedDictionary<string, List<decimal>> currDragon = new SortedDictionary<string, List<decimal>>();
                List<decimal> dragonStats = new List<decimal>();

                if (!allDragons.ContainsKey(type))
                {
                    dragonStats.Add(damage);
                    dragonStats.Add(health);
                    dragonStats.Add(armor);

                    currDragon.Add(name, dragonStats);
                    allDragons.Add(type, currDragon);
                }
                else
                {
                    if (!allDragons[type].ContainsKey(name))
                    {
                        dragonStats.Add(damage);
                        dragonStats.Add(health);
                        dragonStats.Add(armor);
                        
                        allDragons[type].Add(name, dragonStats);
                    }
                    else
                    {
                        dragonStats.Add(damage);
                        dragonStats.Add(health);
                        dragonStats.Add(armor);

                        allDragons[type][name] = dragonStats;
                    }
                }
            }

            foreach (var type in allDragons)
            {
                Console.Write($"{type.Key}::(");

                SortedDictionary<string, List<decimal>> dragonsOfCurrType = type.Value;
                decimal avgDmg = dragonsOfCurrType.Values.Average(a => a[0]);
                decimal avgHealth = dragonsOfCurrType.Values.Average(a => a[1]);
                decimal avgArmor = dragonsOfCurrType.Values.Average(a => a[2]);

                Console.Write("{0:f2}/{1:f2}/{2:f2})", avgDmg, avgHealth, avgArmor);
                Console.WriteLine();

                foreach (var dragon in dragonsOfCurrType)
                {
                    List<decimal> dragonStats = dragon.Value;
                    decimal dmg = dragonStats[0];
                    decimal hp = dragonStats[1];
                    decimal armor = dragonStats[2];

                    Console.WriteLine($"-{dragon.Key} -> damage: {dmg}, health: {hp}, armor: {armor}");
                }
            }
        }
    }
}
