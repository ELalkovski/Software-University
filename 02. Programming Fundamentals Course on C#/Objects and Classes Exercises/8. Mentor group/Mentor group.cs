namespace _8.Mentor_group
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    public class MentorGroup
    {
        public static void Main()
        {
            string[] input = new string[1];
            List<Student> students = new List<Student>();

            while (input[0] != "end")
            {
                input = Console.ReadLine()
                    .Split(" ,".ToCharArray());

                if (input[0] == "end")
                {
                    break;
                }

                string name = input[0];
                List<DateTime> dates = new List<DateTime>();

                if (input.Length > 1)
                {
                    for (int i = 1; i < input.Length; i++)
                    {
                        var date = DateTime.ParseExact(input[i], "dd/MM/yyyy", CultureInfo.InvariantCulture);
                        dates.Add(date);
                    }
                }

                Student currentStudent = new Student()
                {
                    Name = name,
                    Attendings = dates
                };

                if (!students.Any(x => x.Name == name))
                {
                    students.Add(currentStudent);
                }

                else
                {
                    int index = students.FindIndex(x => x.Name == name);
                    students[index].Attendings.AddRange(dates);
                }
            }

            input = new string[1];

            while (input[0] != "end")
            {
                input = Console.ReadLine().Split('-');

                if (input[0] == "end of comments")
                {
                    break;
                }

                string name = input[0];

                if (input.Length > 1)
                {
                    List<string> comments = new List<string>() { input[1] };

                    if (!students.Any(x => x.Name == name))
                    {
                        continue;
                    }

                    int index = students.FindIndex(x => x.Name == name);

                    if (students[index].Comments != null)
                    {
                        students[index].Comments.Add(input[1]);
                    }
                    else
                    {
                        students[index].Comments = comments;
                    }
                }
            }

            foreach (var student in students.OrderBy(x => x.Name))
            {
                Console.WriteLine($"{student.Name}");
                Console.WriteLine("Comments:");

                if (student.Comments != null)
                {
                    foreach (var comment in student.Comments)
                    {
                        Console.WriteLine($"- {comment}");
                    }
                }

                Console.WriteLine("Dates attended:");

                foreach (var date in student.Attendings.OrderBy(x => x.Date))
                {
                    Console.WriteLine($"-- {date.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture)}");
                }
            }
        }
    }
}
