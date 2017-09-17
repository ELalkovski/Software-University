namespace _10.Group_by_Group
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Student
    {
        public string Name { get; set; }

        public int Group { get; set; }
    }

    public class GroupByGroup
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            List<Student> studentsList = new List<Student>();

            while (input != "END")
            {
                string[] tokens = input.Split(' ');
                Student currStudent = new Student();
                currStudent.Name = $"{tokens[0]} {tokens[1]}";
                currStudent.Group = int.Parse(tokens[2]);

                studentsList.Add(currStudent);

                input = Console.ReadLine();
            }

            var groupedStudents = studentsList
                .GroupBy(g => g.Group)
                .OrderBy(x => x.Key);

            foreach (var group in groupedStudents)
            {
                Console.Write($"{group.Key} - ");
                List<string> namesList = new List<string>();

                foreach (var name in group)
                {
                    namesList.Add(name.Name);
                }

                Console.Write(string.Join(", ", namesList));
                Console.WriteLine();
            }
        }
    }
}
