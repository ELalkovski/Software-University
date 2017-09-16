namespace _4.Average_Grades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AverageGrades
    {
        public static void Main()
        {
            const double AverageGradeLimit = 5.00;

            int lineCount = int.Parse(Console.ReadLine());
            
            List<Student> studentsList = new List<Student>();

            for (int i = 0; i < lineCount; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(' ');

                Student student = new Student();
                student.Grades = new List<double>();

                student.Name = input[0];

                for (int j = 1; j <= input.Length - 1; j++)
                {
                    student.Grades.Add(double.Parse(input[j]));
                }

                studentsList.Add(student);
            }

            IOrderedEnumerable<Student> finalList = studentsList
                .OrderBy(x => x.Name)
                .ThenByDescending(x => x.AverageGrade());  

            foreach (Student student in finalList)
            {
                if (student.AverageGrade() >= AverageGradeLimit)
                {
                    Console.WriteLine("{0} -> {1:f2}", student.Name, student.AverageGrade());
                }
            }
        }
    }
}
