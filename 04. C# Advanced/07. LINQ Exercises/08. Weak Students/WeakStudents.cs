namespace _08.Weak_Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class WeakStudents
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            Dictionary<string, List<int>> students = new Dictionary<string, List<int>>();

            while (input != "END")
            {
                string[] tokens = input.Split(' ');
                string name = $"{tokens[0]} {tokens[1]}";
                List<int> grades = new List<int>();

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
