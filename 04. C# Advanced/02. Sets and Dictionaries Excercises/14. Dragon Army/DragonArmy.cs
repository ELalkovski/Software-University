namespace _14.Dragon_Army
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DragonArmy
    {
        public static void Main()
        {
            var inputCount = int.Parse(Console.ReadLine());
            var allDragons = new Dictionary<string, SortedDictionary<string,List<decimal>>>();


            for (int i = 0; i < inputCount; i++)
            {
                var currInput = Console.ReadLine()
                    .Split(' ');

                var type = currInput[0];
                var name = currInput[1];
                var damage = 0m;
                var health = 0m;
                var armor = 0m;
                
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

                var currDragon = new SortedDictionary<string, List<decimal>>();
                var dragonStats = new List<decimal>();

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
                var dragonsOfCurrType = type.Value;

                var avgDmg = dragonsOfCurrType.Values.Average(a => a[0]);
                var avgHealth = dragonsOfCurrType.Values.Average(a => a[1]);
                var avgArmor = dragonsOfCurrType.Values.Average(a => a[2]);

                Console.Write("{0:f2}/{1:f2}/{2:f2})", avgDmg, avgHealth, avgArmor);
                Console.WriteLine();

                foreach (var dragon in dragonsOfCurrType)
                {
                    var dragonStats = dragon.Value;
                    var dmg = dragonStats[0];
                    var hp = dragonStats[1];
                    var armor = dragonStats[2];

                    Console.WriteLine($"-{dragon.Key} -> damage: {dmg}, health: {hp}, armor: {armor}");
                }

            }
        }
    }
}
