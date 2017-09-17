namespace _03.Mankind
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            try
            {
                string[] studentInfo = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string studentFirstName = studentInfo[0];
                string studentLastName = studentInfo[1];
                string facultyNum = studentInfo[2];
                Student student = new Student(studentFirstName, studentLastName, facultyNum);

                string[] workerInfo = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string workerFirstName = workerInfo[0];
                string workerLastName = workerInfo[1];
                decimal weekSalary = decimal.Parse(workerInfo[2]);
                decimal hoursPerWeek = decimal.Parse(workerInfo[3]);
                Worker worker = new Worker(workerFirstName, workerLastName, weekSalary, hoursPerWeek);

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
