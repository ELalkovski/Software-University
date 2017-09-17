namespace _09.Students_Enrolled_in_2014_or_2015
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class GradesByYear
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            Dictionary<string, List<int>> students = new Dictionary<string, List<int>>();

            while (input != "END")
            {
                string[] tokens = input.Split(' ');
                string facultyNum = tokens[0];
                List<int> grades = new List<int>();

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
