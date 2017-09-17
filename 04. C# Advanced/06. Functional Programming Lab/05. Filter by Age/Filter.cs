namespace _05.Filter_by_Age
{
    using System;
    using System.Collections.Generic;

    public class Filter
    {
        private static Dictionary<string, int> people = new Dictionary<string, int>();  

        public static void Main()
        {
            int loopsCount = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < loopsCount; i++)
            {
                string[] inputLine = Console.ReadLine()
                    .Split(new []{", "}, StringSplitOptions.RemoveEmptyEntries);

                string name = inputLine[0];
                int age = int.Parse(inputLine[1]);

                if (!people.ContainsKey(name))
                {
                    people.Add(name, age);
                }
                else
                {
                    people[name] = age;
                }
            }

            string condition = Console.ReadLine();
            int ageBarrier = int.Parse(Console.ReadLine());
            string printFormat = Console.ReadLine();

            Func<int, bool> tester = CreateTester(condition, ageBarrier);
            Action<KeyValuePair<string, int>> printer = CreatePrinter(printFormat);

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
