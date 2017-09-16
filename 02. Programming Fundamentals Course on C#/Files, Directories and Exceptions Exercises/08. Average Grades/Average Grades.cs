namespace _8.Average_Grades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;

    public class AverageGrades
    {
        public static void Main()
        {
            string[] input = File.ReadAllLines("Inputs.txt");
            List<string> firstInput = new List<string>();
            List<string> secondInput = new List<string>();

            firstInput.Add(input[1]);
            firstInput.Add(input[2]);
            firstInput.Add(input[3]);

            secondInput.Add(input[5]);
            secondInput.Add(input[6]);
            secondInput.Add(input[7]);
            secondInput.Add(input[8]);
            secondInput.Add(input[9]);
            secondInput.Add(input[10]);

            foreach (var name in GetFirstInputResults(firstInput).OrderBy(x => x.Name).ThenByDescending(x => x.AverageGrade()))
            {
                if (name.AverageGrade() >= 5.00)
                {
                    Console.WriteLine("{0} -> {1:f2}", name.Name, name.AverageGrade());
                    File.AppendAllText("Output.txt", name.Name + " -> " + name.AverageGrade() + Environment.NewLine);
                }
            }

            foreach (var name in GetSecondInputResults(secondInput).OrderBy(x => x.Name).ThenByDescending(x => x.AverageGrade()))
            {
                if (name.AverageGrade() >= 5.00)
                {
                    Console.WriteLine("{0} -> {1:f2}", name.Name, name.AverageGrade());
                    File.AppendAllText("Output.txt", name.Name + " -> " + name.AverageGrade() + Environment.NewLine);
                }
            }
        }

        public static List<Student> GetFirstInputResults(List<string> firstInput)
        {
            List<Student> results = new List<Student>();

            for (int i = 0; i < firstInput.Count; i++)
            {
                Student student = new Student();
                List<string> dataFirstInput = firstInput[i]
                    .Split(' ')
                    .ToList();

                student.Name = dataFirstInput[0];
                List<double> grades = new List<double>();

                for (int j = 1; j < dataFirstInput.Count; j++)
                {
                    grades.Add(double.Parse(dataFirstInput[j]));
                }

                student.Grades = grades;
                results.Add(student);
            }

            return results;
        }

        public static List<Student> GetSecondInputResults(List<string> secondInput)
        {
            List<Student> results = new List<Student>();

            for (int i = 0; i < secondInput.Count; i++)
            {
                Student student = new Student();
                List<string> dataSecondInput = secondInput[i]
                    .Split(' ')
                    .ToList();

                student.Name = dataSecondInput[0];
                List<double> grades = new List<double>();

                for (int j = 1; j < dataSecondInput.Count; j++)
                {
                    grades.Add(double.Parse(dataSecondInput[j]));
                }

                student.Grades = grades;
                results.Add(student);
            }

            return results;
        }
    }
}
