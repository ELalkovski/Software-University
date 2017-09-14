namespace Employee_Data
{
    using System;

    public class EmployeeData
    {
        public static void Main()
        {
            string firstName = "Amanda";
            string lastName = "Jonson";
            byte age = 27;
            char gender = 'f';
            string personalNumber = "8306112507";
            string uniqueNumber = "27563571";

            Console.WriteLine("First name: {0}",firstName);
            Console.WriteLine("Last name: {0}",lastName);
            Console.WriteLine("Age: {0}",age);
            Console.WriteLine("Gender: {0}",gender);
            Console.WriteLine("Personal ID: {0}",personalNumber);
            Console.WriteLine("Unique Employee number: {0}",uniqueNumber);
        }
    }
}
