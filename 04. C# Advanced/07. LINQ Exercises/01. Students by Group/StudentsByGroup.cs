namespace _01.Students_by_Group
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StudentsByGroup
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            List<List<string>> allStudents = new List<List<string>>();

            while (input != "END")
            {
                List<string> tokens = input.Split(' ').ToList();
                string group = tokens[2];

                if (group == "2")
                {
                    allStudents.Add(tokens);
                }
                
                input = Console.ReadLine();
            }

            allStudents
                .OrderBy(arr => arr[0])
                .ToList()
                .ForEach(s => Console.WriteLine($"{s[0]} {s[1]}"));
        }
    }
}
