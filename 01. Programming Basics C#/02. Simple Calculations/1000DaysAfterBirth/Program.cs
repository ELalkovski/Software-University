using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _1000DaysAfterBirth
{
    class Program
    {
        static void Main(string[] args)
        {
            string dateSTR = Console.ReadLine();
            string format = "dd-MM-yyyy";
            DateTime date = DateTime.ParseExact(dateSTR, format, CultureInfo.InvariantCulture).AddDays(999);
            Console.WriteLine(date.ToString(format));

        }
    }
}
