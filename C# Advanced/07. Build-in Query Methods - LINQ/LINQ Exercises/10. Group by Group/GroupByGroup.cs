using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.Group_by_Group
{
    public class Student
    {
        public string Name { get; set; }

        public int Group { get; set; }
    }

    public class GroupByGroup
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var studentsList = new List<Student>();

            while (input != "END")
            {
                var tokens = input.Split(' ');
                var currStudent = new Student();
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
                var namesList = new List<string>();
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
