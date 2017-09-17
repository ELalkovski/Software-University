namespace _05.Border_Control
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var inputLines = Console.ReadLine();
            var checkedCitizens = new List<IIdentificationable>();

            while (inputLines != "End")
            {
                var tokens = inputLines.Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries);

                if (tokens.Length == 3)
                {
                    IIdentificationable person = new Person(tokens[0], int.Parse(tokens[1]), tokens[2]);
                    checkedCitizens.Add(person);
                }
                else
                {
                    IIdentificationable robot = new Robot(tokens[0], tokens[1]);
                    checkedCitizens.Add(robot);
                }
                
                inputLines = Console.ReadLine();
            }

            var fakeIdsLastDigits = Console.ReadLine();

            checkedCitizens
                .FindAll(c => c.IsIdFake(fakeIdsLastDigits))
                .ToList()
                .ForEach(i => Console.WriteLine(i.Id));
        }
    }
}
