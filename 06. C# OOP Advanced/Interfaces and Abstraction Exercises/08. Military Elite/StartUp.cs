using System;
using System.Collections.Generic;
using System.Linq;
using _08.Military_Elite.Entities;
using _08.Military_Elite.Interfaces;

namespace _08.Military_Elite
{
    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var privates = new List<Private>();

            while (input != "End")
            {
                var info = input.Split(' ').ToList();
                var type = info[0];
                info.RemoveAt(0);

                switch (type)
                {
                    case "Private":
                        var soldier = new Private(info[0], info[1], info[2], double.Parse(info[3]));
                        privates.Add(soldier);
                        Console.WriteLine(soldier.ToString());
                        break;
                    case "LeutenantGeneral":
                        var leutenant = new LeutenantGeneral(info[0], info[1], info[2], double.Parse(info[3]));
                        for (int i = 4; i < info.Count; i++)
                        {
                            var id = info[i];

                            leutenant.AddPrivate(privates.First(p => p.Id.Equals(id)));
                        }

                        Console.WriteLine(leutenant.ToString());
                        break;
                    case "Engineer":
                        if (info[4] == "Airforces" || info[4] == "Marines")
                        {
                            var engineer = new Engeneer(info[0], info[1], info[2], double.Parse(info[3]), info[4]);

                            for (int i = 5; i < info.Count; i += 2)
                            {
                                var repair = new Repair(info[i], int.Parse(info[i + 1]));
                                engineer.AddRepair(repair);
                            }

                            Console.WriteLine(engineer.ToString());
                        }
                        break;
                    case "Commando":
                        if (info[4] == "Airforces" || info[4] == "Marines")
                        {
                            var commando = new Commando(info[0], info[1], info[2], double.Parse(info[3]), info[4]);

                            for (int i = 5; i < info.Count; i += 2)
                            {
                                if (info[i + 1] == "inProgress" || info[i + 1] == "Finished")
                                {
                                    var mission = new Mission(info[i], info[i + 1]);
                                    commando.AddMission(mission);
                                }
                            }

                            Console.WriteLine(commando.ToString());
                        }
                        break;
                    case "Spy":
                        var spy = new Spy(info[0], info[1], info[2], int.Parse(info[3]));

                        Console.WriteLine(spy.ToString());
                        break;

                }

                input = Console.ReadLine();
            }
        }
    }
}
