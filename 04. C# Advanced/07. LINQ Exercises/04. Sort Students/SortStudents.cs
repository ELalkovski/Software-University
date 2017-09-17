namespace _04.Sort_Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SortStudents
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            List<List<string>> allStudents = new List<List<string>>();

            while (input != "END")
            {
                allStudents.Add(input.Split(' ').ToList());

                input = Console.ReadLine();
            }

            allStudents
                .OrderBy(n => n[1])
                .ThenByDescending(n => n[0])
                .ToList()
                .ForEach(s => Console.WriteLine($"{s[0]} {s[1]}"));
        }
    }
}
