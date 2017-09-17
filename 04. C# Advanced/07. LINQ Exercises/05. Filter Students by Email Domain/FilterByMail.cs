namespace _05.Filter_Students_by_Email_Domain
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FilterByMail
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
                .Where(s => s[2].Contains("@gmail.com"))
                .ToList()
                .ForEach(s => Console.WriteLine($"{s[0]} {s[1]}"));
        }
    }
}
