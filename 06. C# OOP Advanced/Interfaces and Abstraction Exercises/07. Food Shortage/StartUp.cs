namespace _07.Food_Shortage
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var numberOfPeople = int.Parse(Console.ReadLine());
            var buyers = new List<IBuyer>();

            for (int i = 0; i < numberOfPeople; i++)
            {
                var peopleInfo = Console.ReadLine()
                    .Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries);

                if (peopleInfo.Length == 4)
                {
                    IBuyer citizen = new Citizen(peopleInfo[0], int.Parse(peopleInfo[1]), peopleInfo[2], peopleInfo[3]);
                    buyers.Add(citizen);
                }
                else
                {
                    IBuyer rebel = new Rebel(peopleInfo[0], int.Parse(peopleInfo[1]), peopleInfo[2]);
                    buyers.Add(rebel);
                }
            }

            var name = Console.ReadLine();

            while (name != "End")
            {
                if (buyers.Any(b => b.Name.Equals(name)))
                {
                    buyers.First(b => b.Name.Equals(name)).BuyFood();
                }

                name = Console.ReadLine();
            }

            Console.WriteLine(buyers.Sum(b => b.Food));
        }
    }
}
