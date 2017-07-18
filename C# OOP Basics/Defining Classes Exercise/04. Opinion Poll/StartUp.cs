using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Opinion_Poll
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var people = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                var inputTokens = Console.ReadLine()
                    .Split(' ');
                var name = inputTokens[0];
                var age = int.Parse(inputTokens[1]);

                var currPerson = new Person(name, age);
                people.Add(currPerson);
            }

            foreach (var person in people.FindAll(p => p.Age > 30).OrderBy(p => p.Name))
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
