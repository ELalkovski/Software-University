namespace _01._Student_System
{
    using System;
    using P01_StudentSystem.Data;
    using P01_StudentSystem.Data.Models;
    using System.Linq;

    public class StartUp
    {
        public const string ExitCommand = "exit";

        public static void Main()
        {
            using (var db = new StudentSystemContext())
            {
                ResetDatabase(db);
                //string command;
                //PrintHelp();

                //while ((command = Console.ReadLine()) != ExitCommand)
                //{
                //    ExecuteCommand(command, db);
                //    PrintHelp();
                //}
            }
        }

        private static void PrintHelp()
        {
            Console.WriteLine("Welcome to the students system database!");
            Console.WriteLine("Choose one of the folowing choices:");
            Console.WriteLine("1. \"find\" student {name} - Displays student details");
            Console.WriteLine("2. \"find\" course {name} - Displays course details");
            Console.WriteLine("3. \"exit\" - Exit the application");
            Console.Write("The system expects your choice: ");
        }

        private static void ExecuteCommand(string command, StudentSystemContext db)
        {            
            switch (command)
            {
                case "course":
                    Console.Write("Please enter course name: ");
                    string courseName = Console.ReadLine();

                    Course selectedCourse = db.Courses
                        .FirstOrDefault(c => c.Name
                        .Equals(courseName));

                    if (selectedCourse != null)
                    {
                        Console.WriteLine($"Course name: {selectedCourse.Name}");
                        Console.WriteLine($"Start date: {selectedCourse.StartDate.ToString()}");
                        Console.WriteLine($"End date: {selectedCourse.EndDate.ToString()}");
                        Console.WriteLine("Subscribed students: ");

                        foreach (var student in selectedCourse.StudentsEnrolled)
                        {
                            Console.WriteLine($"-- Student name: {student.Student.Name}");
                            Console.WriteLine($"-- Register date: {student.Student.RegisteredOn}");
                            Console.WriteLine($"-- Phone number: {student.Student.PhoneNumber}");

                            foreach (var homework in student.Student.HomeworkSubmissions)
                            {
                                Console.WriteLine($"---- Content: {homework.ContentType}");
                                Console.WriteLine($"---- Submitted at: {homework.SubmissionTime}");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("There is no course with such a name!");
                    }

                    Console.WriteLine();
                    break;
            }
        }

        private static void ResetDatabase(StudentSystemContext db)
        {
            db.Database.EnsureDeleted();
            db.Database.EnsureCreated();
            Seed(db);
        }

        //Fills database with some sample data
        //
        private static void Seed(StudentSystemContext db)
        {
            Student[] students = new Student[]
            {
                new Student
                {
                    Name = "Pesho",
                    Birthday = DateTime.Parse("01/01/1993")
                },

                new Student
                {
                    Name = "Gosho",
                    Birthday = DateTime.Parse("01/03/1995")
                },

                new Student
                {
                    Name = "Maria",
                    Birthday = DateTime.Parse("01/11/1992")
                },

                new Student
                {
                    Name = "Penka",
                    Birthday = DateTime.Parse("01/08/1993")
                },
            };
            db.Students.AddRange(students);

            Course[] courses = new Course[]
            {
                new Course
                {
                    Name = "C# Fundamentals",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Parse("02/12/2017"),
                    Price = 299.00m
                },

                new Course
                {
                    Name = "Java Fundamentals",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Parse("02/01/2018"),
                    Price = 199.00m
                },

                new Course
                {
                    Name = "SQL Server Basics",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Parse("03/01/2018"),
                    Price = 199.00m
                },
            };
            db.Courses.AddRange(courses);

            Resource[] resources = new Resource[]
            {
                new Resource
                {
                    Name = "Presentation",
                    Url = "www.presentation.com",
                    ResourceType = ResourceType.Presentation,
                    CourseId = 1,
                    Course = courses[0]
                },

                new Resource
                {
                    Name = "Document",
                    Url = "www.document.com",
                    ResourceType = ResourceType.Document,
                    CourseId = 2,
                    Course = courses[1]
                },

                new Resource
                {
                    Name = "Video",
                    Url = "www.video.com",
                    ResourceType = ResourceType.Video,
                    CourseId = 3,
                    Course = courses[2]
                },
            };
            db.Resources.AddRange(resources);

            Homework[] homeworkSubmissions = new Homework[]
            {
                new Homework
                {
                    Content = "Content1.pdf",
                    ContentType = ContentType.Pdf,
                    StudentId = 1,
                    Student = students[0],
                    CourseId = 1,
                    Course = courses[0]
                },

                new Homework
                {
                    Content = "Content2.zip",
                    ContentType = ContentType.Zip,
                    StudentId = 2,
                    Student = students[1],
                    CourseId = 2,
                    Course = courses[1]
                },

                new Homework
                {
                    Content = "Content3.exe",
                    ContentType = ContentType.Application,
                    StudentId = 3,
                    Student = students[2],
                    CourseId = 3,
                    Course = courses[2]
                },
            };
            db.HomeworkSubmissions.AddRange(homeworkSubmissions);

            StudentCourse[] studentCourses = new StudentCourse[]
            {
                new StudentCourse
                {
                    Student = students[0],
                    Course = courses[1]
                },

                new StudentCourse
                {
                    Student = students[2],
                    Course = courses[0]
                },

                new StudentCourse
                {
                    Student = students[1],
                    Course = courses[2]
                },
            };
            db.StudentCourses.AddRange(studentCourses);

            db.SaveChanges();
        }
    }
}
