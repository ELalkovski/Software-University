namespace _06.Birthday_Celebrations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var inputLines = Console.ReadLine();
            var checkedCitizens = new List<IBirthable>();

            while (inputLines != "End")
            {
                var tokens = inputLines.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                switch (tokens[0])
                {
                    case "Citizen":
                        IBirthable person = new Person(tokens[1], int.Parse(tokens[2]), tokens[3], tokens[4]);
                        checkedCitizens.Add(person);
                        break;
                    case "Pet":
                        IBirthable pet = new Pet(tokens[1], tokens[2]);
                        checkedCitizens.Add(pet);
                        break;
                }
               
                inputLines = Console.ReadLine();
            }

            var yearOfBirth = Console.ReadLine();

            checkedCitizens
                .FindAll(c => c.BirthDate.EndsWith(yearOfBirth))
                .ToList()
                .ForEach(c => Console.WriteLine(c.BirthDate));
        }
    }
}
