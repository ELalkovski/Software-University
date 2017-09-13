using System;
using System.Collections.Generic;

namespace _05.Filter_by_Age
{
    public class Filter
    {
        private static Dictionary<string, int> people = new Dictionary<string, int>();  

        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                var inputLine = Console.ReadLine()
                    .Split(new []{", "}, StringSplitOptions.RemoveEmptyEntries);

                var name = inputLine[0];
                var age = int.Parse(inputLine[1]);

                if (!people.ContainsKey(name))
                {
                    people.Add(name, age);
                }
                else
                {
                    people[name] = age;
                }
            }

            var condition = Console.ReadLine();
            var ageBarrier = int.Parse(Console.ReadLine());
            var printFormat = Console.ReadLine();

            var tester = CreateTester(condition, ageBarrier);
            var printer = CreatePrinter(printFormat);

            PrintResult(tester, printer);
        }

        private static void PrintResult(Func<int, bool> tester, Action<KeyValuePair<string, int>> printer)
        {
            foreach (var person in people)
            {
                if (tester(person.Value))
                {
                    printer(person);
                }
                
            }
        }

        public static Action<KeyValuePair<string, int>> CreatePrinter(string printFormat)
        {
            switch (printFormat)
            {
                case "name age": return people => Console.WriteLine($"{people.Key} - {people.Value}");
                case "name": return people => Console.WriteLine($"{people.Key}");
                case "age": return people => Console.WriteLine($"{people.Value}");
                default: return null;
            }
        }

        public static Func<int, bool> CreateTester(string condition, int age)
        {
            switch (condition)
            {
                case "younger": return x => x <= age;
                case "older": return x => x >= age;
                default: return null;
            }
        }
    }
}
