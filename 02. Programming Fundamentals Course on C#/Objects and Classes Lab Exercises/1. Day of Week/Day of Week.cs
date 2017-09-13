using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _1.Day_of_Week
{
     class DayOfWeek
    {
        public static void Main()
        {
            var dateAsText = Console.ReadLine();
            DateTime date = DateTime.ParseExact(
                dateAsText, "d-M-yyyy",
                CultureInfo.InvariantCulture);
            Console.WriteLine(date.DayOfWeek);
        }
    }
}
