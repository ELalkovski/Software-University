using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Students_by_Age
{
    public class StudentsByAge
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var allStudents = new Dictionary<string, int>();

            while (input != "END")
            {
                var tokens = input.Split(' ');
                var name = $"{tokens[0]} {tokens[1]}";
                var age = int.Parse(tokens[2]);

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
