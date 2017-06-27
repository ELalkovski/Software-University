using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Students_by_First_and_Last_Name
{
    public class StudentsByFirst
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var allStudents = new List<List<string>>();

            while (input != "END")
            {
                allStudents.Add(input.Split(' ').ToList());

                input = Console.ReadLine();
            }

            allStudents.Where(s => String.Compare(s[0], s[1]) < 0)
            .ToList()
            .ForEach(s => Console.WriteLine($"{s[0]} {s[1]}"));
        }
    }
}
