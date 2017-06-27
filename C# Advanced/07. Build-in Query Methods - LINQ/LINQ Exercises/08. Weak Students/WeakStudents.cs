using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Weak_Students
{
    public class WeakStudents
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var students = new Dictionary<string, List<int>>();

            while (input != "END")
            {
                var tokens = input.Split(' ');
                var name = $"{tokens[0]} {tokens[1]}";
                var grades = new List<int>();

                for (int i = 2; i < tokens.Length; i++)
                {
                    grades.Add(int.Parse(tokens[i]));
                }

                students.Add(name, grades);
                input = Console.ReadLine();
            }

            
            foreach (var student in students.Where(s => s.Value.Where(g => g <= 3).ToList().Count >= 2))
            {
                Console.WriteLine($"{student.Key}");
            }
        }
    }
}
