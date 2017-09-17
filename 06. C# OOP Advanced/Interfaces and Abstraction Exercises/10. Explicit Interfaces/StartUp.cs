using System;

namespace _10.Explicit_Interfaces
{
    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            while (input != "End")
            {
                var citizenInfo = input.Split(' ');
                var citizen = new Citizen(citizenInfo[0], citizenInfo[1], citizenInfo[2]);
                Console.WriteLine(((IPerson)citizen).GetName());
                Console.WriteLine(((IResident)citizen).GetName());

                input = Console.ReadLine();
            }
        }
    }
}
