namespace _03.Students_by_Age
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StudentsByAge
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            Dictionary<string, int> allStudents = new Dictionary<string, int>();

            while (input != "END")
            {
                string[] tokens = input.Split(' ');
                string name = $"{tokens[0]} {tokens[1]}";
                int age = int.Parse(tokens[2]);

                allStudents.Add(name, age);

                input = Console.ReadLine();
            }

            foreach (var student in allStudents.Where(s => s.Value >= 18 && s.Value <= 24))
            {
                Console.WriteLine($"{student.Key} {student.Value}");
            }
        }
    }
}
