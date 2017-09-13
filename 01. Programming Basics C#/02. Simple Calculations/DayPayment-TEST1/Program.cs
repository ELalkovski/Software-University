using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayPayment_TEST1
{
    class Program
    {
        static void Main(string[] args)
        {
            var workingDays = int.Parse(Console.ReadLine());
            var dayPayment = double.Parse(Console.ReadLine());
            var usdCourse = double.Parse(Console.ReadLine());

           
            double Salary = workingDays * dayPayment;
            double YearSalary = Salary * 12 + Salary * 2.5;
            double Taxes = YearSalary * 0.25;
            double CleanYear = (YearSalary - Taxes)*usdCourse;
            double DayPayment = CleanYear / 365;

            Console.WriteLine(Math.Round(DayPayment,2));
             
        }
    }
}
