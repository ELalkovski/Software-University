using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.Students_Enrolled_in_2014_or_2015
{
    public class GradesByYear
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var students = new Dictionary<string, List<int>>();

            while (input != "END")
            {
                var tokens = input.Split(' ');
                var facultyNum = tokens[0];
                var grades = new List<int>();

                for (int i = 1; i < tokens.Length; i++)
                {
                    grades.Add(int.Parse(tokens[i]));
                }

                students.Add(facultyNum, grades);
                input = Console.ReadLine();
            }

            foreach (var facultyNum in students.Where(s => s.Key.EndsWith("14") || s.Key.EndsWith("15")))
            {
                Console.WriteLine(string.Join(" ", facultyNum.Value));
            }
        }
    }
}
