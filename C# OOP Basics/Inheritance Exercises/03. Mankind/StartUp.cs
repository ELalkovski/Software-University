using System;

namespace _03.Mankind
{
    public class StartUp
    {
        public static void Main()
        {
            try
            {
                var studentInfo = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var studentFirstName = studentInfo[0];
                var studentLastName = studentInfo[1];
                var facultyNum = studentInfo[2];
                var student = new Student(studentFirstName, studentLastName, facultyNum);

                var workerInfo = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var workerFirstName = workerInfo[0];
                var workerLastName = workerInfo[1];
                var weekSalary = decimal.Parse(workerInfo[2]);
                var hoursPerWeek = decimal.Parse(workerInfo[3]);
                var worker = new Worker(workerFirstName, workerLastName, weekSalary, hoursPerWeek);



                Console.WriteLine(student);
                Console.WriteLine();
                Console.WriteLine(worker);
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
