using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Time_15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine()) + 15;
            string zero = "";

            if (minutes > 59)
            {
                hours += 1;
                minutes -= 60;
            }

            if (minutes < 10)
            {
                zero = "0";
            }

            Console.WriteLine("{0}:{1}{2}", hours % 24, zero, minutes % 60);

        }
    }
}
