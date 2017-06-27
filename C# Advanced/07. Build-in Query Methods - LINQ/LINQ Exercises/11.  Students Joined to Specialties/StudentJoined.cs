using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.Students_Joined_to_Specialties
{
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
            var input = Console.ReadLine();
            var spacialitiesList = new List<StudentSpecialty>();

            while (input != "Students:")
            {
                var tokens = input.Split();
                var currSpecialty = new StudentSpecialty();
                currSpecialty.SpeacialtyName = $"{tokens[0]} {tokens[1]}";
                currSpecialty.FacultyNumber = tokens[2];

                spacialitiesList.Add(currSpecialty);

                input = Console.ReadLine();
            }

            var students = new List<Student>();
            input = Console.ReadLine();

            while (input != "END")
            {
                var tokens = input.Split();
                var currStudent = new Student();
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
