using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Students_by_Group
{

    public class StudentsByGroup
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var allStudents = new List<List<string>>();

            while (input != "END")
            {
                var tokens = input.Split(' ').ToList();
                var group = tokens[2];

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
