namespace DayPayment_TEST1
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int workingDays = int.Parse(Console.ReadLine());
            double dayPayment = double.Parse(Console.ReadLine());
            double usdCourse = double.Parse(Console.ReadLine());
           
            double Salary = workingDays * dayPayment;
            double YearSalary = Salary * 12 + Salary * 2.5;
            double Taxes = YearSalary * 0.25;
            double CleanYear = (YearSalary - Taxes)*usdCourse;
            double DayPayment = CleanYear / 365;

            Console.WriteLine(Math.Round(DayPayment,2));
        }
    }
}
