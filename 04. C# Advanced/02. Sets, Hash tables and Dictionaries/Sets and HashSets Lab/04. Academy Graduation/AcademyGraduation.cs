namespace _04.Academy_Graduation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AcademyGraduation
    {
        public static void Main()
        {
            /*
             
             This program:
             •	Reads from console number of student for a track
             •	Reads on pair of rows:
             o	First line is name of student
             o	Second line is his score for different number of courses
             •	Prints on the console “{name} is graduated with {average scores)”

             */

            var inputLinesCount = int.Parse(Console.ReadLine());
            var students = new SortedDictionary<string, List<double>>();
            var grades = new List<double>();

            for (int i = 0; i < inputLinesCount; i++)
            {
                var studentName = Console.ReadLine();

                var studentGrades = Console.ReadLine()
                    .Split(new char [] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .ToList();

                if (!students.ContainsKey(studentName))
                {
                    students[studentName] = studentGrades;
                }
                else
                {
                    foreach (var grade in grades)
                    {
                        students[studentName].Add(grade);
                    }
                }
            }

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Key} is graduated with {student.Value.Average()}");
            }
        }
    }
}
