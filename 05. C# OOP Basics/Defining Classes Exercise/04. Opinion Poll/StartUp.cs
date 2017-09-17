namespace _04.Opinion_Poll
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int loopsCount = int.Parse(Console.ReadLine());

            List<Person> people = new List<Person>();

            for (int i = 0; i < loopsCount; i++)
            {
                string[] inputTokens = Console.ReadLine()
                    .Split(' ');

                string name = inputTokens[0];
                int age = int.Parse(inputTokens[1]);

                Person currPerson = new Person(name, age);
                people.Add(currPerson);
            }

            foreach (var person in people.FindAll(p => p.Age > 30).OrderBy(p => p.Name))
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
