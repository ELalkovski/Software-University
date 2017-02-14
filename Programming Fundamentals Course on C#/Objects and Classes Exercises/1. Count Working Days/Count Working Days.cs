namespace _1.Count_Working_Days
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;


    class CountWorkingDays
    {
        public static void Main()
        {
            var firstInput = Console.ReadLine();
            var secondInput = Console.ReadLine();

            var start = DateTime.ParseExact(firstInput, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            var end = DateTime.ParseExact(secondInput, "dd-MM-yyyy", CultureInfo.InvariantCulture);


            DateTime[] holidays = new DateTime[11];

            holidays[0] = new DateTime(4, 01, 01);
            holidays[1] = new DateTime(4, 03, 03);
            holidays[2] = new DateTime(4, 05, 01);
            holidays[3] = new DateTime(4, 05, 06);
            holidays[4] = new DateTime(4, 05, 24);
            holidays[5] = new DateTime(4, 09, 06);
            holidays[6] = new DateTime(4, 09, 22);
            holidays[7] = new DateTime(4, 11, 01);
            holidays[8] = new DateTime(4, 12, 24);
            holidays[9] = new DateTime(4, 12, 25);
            holidays[10] = new DateTime(4, 12, 26);

            var workingDays = 0;

            for (DateTime currDay = start; currDay <= end; currDay = currDay.AddDays(1))
            {
                DayOfWeek day = currDay.DayOfWeek;
                DateTime temp = new DateTime(4, currDay.Month, currDay.Day);

                if (!holidays.Contains(temp) && day != DayOfWeek.Saturday && day != DayOfWeek.Sunday)
                {
                    workingDays++;
                }
            }

            Console.WriteLine(workingDays);
            
        }
    }
}
