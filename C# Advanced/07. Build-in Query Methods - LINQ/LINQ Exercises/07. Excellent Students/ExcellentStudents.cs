using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.Excellent_Students
{
    public class ExcellentStudents
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var students = new Dictionary<string, List<string>>();

            while (input != "END")
            {
                var tokens = input.Split(' ');
                var name = $"{tokens[0]} {tokens[1]}";
                var grades = new List<string>();

                for (int i = 2; i < tokens.Length; i++)
                {
                    grades.Add(tokens[i]);
                }

                students.Add(name, grades);
                input = Console.ReadLine();
            }

            foreach (var student in students.Where(s => s.Value.Contains("6")))
            {
                Console.WriteLine($"{student.Key}");
            }
        }
    }
}
