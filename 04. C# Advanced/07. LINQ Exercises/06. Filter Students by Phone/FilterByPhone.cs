namespace _06.Filter_Students_by_Phone
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FilterByPhone
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
                .Where(s => s[2].StartsWith("02") || s[2].StartsWith("+3592"))
                .ToList()
                .ForEach(s => Console.WriteLine($"{s[0]} {s[1]}"));
        }
    }
}
