namespace _11.Students_Joined_to_Specialties
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StudentSpecialty
    {
        public string SpeacialtyName { get; set; }

        public string FacultyNumber { get; set; }
    }

    public class Student
    {
        public string Name { get; set; }

        public string FacultyNumber { get; set; }
    }

    public class StudentJoined
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            List<StudentSpecialty> spacialitiesList = new List<StudentSpecialty>();

            while (input != "Students:")
            {
                string[] tokens = input.Split();
                StudentSpecialty currSpecialty = new StudentSpecialty();
                currSpecialty.SpeacialtyName = $"{tokens[0]} {tokens[1]}";
                currSpecialty.FacultyNumber = tokens[2];

                spacialitiesList.Add(currSpecialty);

                input = Console.ReadLine();
            }

            List<Student> students = new List<Student>();

            input = Console.ReadLine();

            while (input != "END")
            {
                string[] tokens = input.Split();
                Student currStudent = new Student();
                currStudent.Name = $"{tokens[1]} {tokens[2]}";
                currStudent.FacultyNumber = tokens[0];

                students.Add(currStudent);

                input = Console.ReadLine();
            }

            var result = spacialitiesList.Join(students, ss => ss.FacultyNumber, student => student.FacultyNumber,
                (ss, student) => new
                {
                    Name = student.Name,
                    FacultyNum = student.FacultyNumber,
                    Specialty = ss.SpeacialtyName
                });

            foreach (var student in result.OrderBy(s => s.Name))
            {
                Console.WriteLine($"{student.Name} {student.FacultyNum} {student.Specialty}");
            }
        }
    }
}
