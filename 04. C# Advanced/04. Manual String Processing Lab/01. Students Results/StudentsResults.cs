namespace _01.Students_Results
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StudentsResults
    {
        public static void Main()
        {
            int inputCount = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

            for (int i = 0; i < inputCount; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(new[]{' ', ',', '-'}, StringSplitOptions.RemoveEmptyEntries);

                string name = input[0];
                double firstResult = double.Parse(input[1]);
                double secondResult = double.Parse(input[2]);
                double thirdResult = double.Parse(input[3]);

                if (students.ContainsKey(name))
                {
                    students[name][0] = firstResult;
                    students[name][1] = secondResult;
                    students[name][2] = thirdResult;
                }
                else
                {
                    students[name] = new List<double>();
                    students[name].Add(firstResult);
                    students[name].Add(secondResult);
                    students[name].Add(thirdResult);
                }
            }
            
            Console.WriteLine(string.Format("{0, -10}|{1, 7}|{2, 7}|{3, 7}|{4, 7}|", "Name", "CAdv", "COOP", "AdvOOP", "Average"));

            foreach (var student in students)
            {
                Console.WriteLine(string.Format("{0, -10}|{1, 7:f2}|{2, 7:f2}|{3, 7:f2}|{4, 7:f4}|", student.Key
                    , student.Value[0], student.Value[1], student.Value[2], student.Value.Average()));

            }
        }
    }
}
