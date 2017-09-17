namespace _02.King_s_Gambit
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            King king = new King(Console.ReadLine());
            List<Soldier> army = new List<Soldier>();

            var guardsNames = Console.ReadLine()
                .Split(' ');
            var footmenNames = Console.ReadLine()
                .Split(' ');

            foreach (var name in guardsNames)
            {
                RoyalGuard guard = new RoyalGuard(name);
                army.Add(guard);
                king.UnderAttack += guard.KingUnderAttack;
            }
            foreach (var name in footmenNames)
            {
                Footman footman = new Footman(name);
                army.Add(footman);
                king.UnderAttack += footman.KingUnderAttack;
            }

            var order = Console.ReadLine();

            while (order != "End")
            {
                if (order == "Attack King")
                {
                    king.KingUnderAttack();
                }
                else
                {
                    var tokens = order.Split(' ');

                    Soldier soldier = army.FirstOrDefault(s => s.Name.Equals(tokens[1]));
                    king.UnderAttack -= soldier.KingUnderAttack;
                    army.Remove(soldier);
                }

                order = Console.ReadLine();
            }
        }
    }
}
