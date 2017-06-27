namespace _8.Mentor_group
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;



    class MentorGroup
    {
        public static void Main()
        {
            var input = new string[1];
            var students = new List<Student>();

            while (input[0] != "end")
            {
                input = Console.ReadLine().Split(" ,".ToCharArray());
                if (input[0] == "end")
                {
                    break;
                }

                var name = input[0];
                var dates = new List<DateTime>();

                if (input.Length > 1)
                {
                    for (int i = 1; i < input.Length; i++)
                    {
                        var date = DateTime.ParseExact(input[i], "dd/MM/yyyy", CultureInfo.InvariantCulture);
                        dates.Add(date);
                    }
                }

                var currentStudent = new Student() { Name = name, Attendings = dates };

                if (!students.Any(x => x.Name == name))
                {
                    students.Add(currentStudent);
                }

                else
                {
                    var index = students.FindIndex(x => x.Name == name);
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

                var name = input[0];

                if (input.Length > 1)
                {
                    var comments = new List<string>() { input[1] };

                    if (!students.Any(x => x.Name == name))
                    {
                        continue;
                    }

                    var index = students.FindIndex(x => x.Name == name);
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
            //var input = Console.ReadLine();

            //var students = new SortedDictionary<string, Student>();

            //while (input != "end of dates")
            //{
            //    var data = input.Split(' ');
            //    var currName = data[0];
            //    var attendings = new List<DateTime>();
            //    var dates = data[1].Split(',').ToArray();

            //    if (data.Length > 1)
            //    {  
            //        for (int i = 0; i < dates.Length; i++)
            //        {
            //            var currDate = DateTime.ParseExact(dates[i], "dd/MM/yyyy", CultureInfo.InvariantCulture);
            //            attendings.Add(currDate);
            //        }              
            //    }

            //    var student = new Student();
            //    student.Name = currName;

            //    if (!students.ContainsKey(currName))
            //    {
            //        students.Add(currName, student);
            //        student.Attendings = attendings;
            //    }
            //    else
            //    {
            //        students[currName].Attendings.AddRange(attendings);
            //    }

            //    input = Console.ReadLine();
            //}

            //var commentsInput = Console.ReadLine();

            //while (commentsInput != "end of comments")
            //{
            //    var commentsData = commentsInput.Split('-');
            //    var name = commentsData[0];
            //    var comment = commentsData[1];
            //    var comments = new List<string>();
            //    comments.Add(comment);

            //    if (students.ContainsKey(name))
            //    {
            //        if (students[name].Comments != null)
            //        {
            //            students[name].Comments.AddRange(comments);
            //        }
            //        else
            //        {
            //            students[name].Comments = comments;
            //        }
            //    }
            //    commentsInput = Console.ReadLine();
            //}

            //foreach (var entry in students)
            //{
            //    Console.WriteLine("{0}", entry.Key);
            //    Console.WriteLine("Comments:");
            //    if (entry.Value.Comments != null)
            //    {
            //        foreach (var comment in entry.Value.Comments)
            //        {
            //            Console.WriteLine("- {0}", comment);
            //        }
            //    }
            //    Console.WriteLine("Dates attended:");

            //    foreach (var date in entry.Value.Attendings.OrderBy(d => d))
            //    {
            //        Console.WriteLine("-- {0}", date.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture));
            //    }


            //}
        }
    }
}
