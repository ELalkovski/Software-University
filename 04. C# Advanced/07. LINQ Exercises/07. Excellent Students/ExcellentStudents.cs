namespace _07.Excellent_Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ExcellentStudents
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            Dictionary<string, List<string>> students = new Dictionary<string, List<string>>();

            while (input != "END")
            {
                string[] tokens = input.Split(' ');
                string name = $"{tokens[0]} {tokens[1]}";
                List<string> grades = new List<string>();

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
