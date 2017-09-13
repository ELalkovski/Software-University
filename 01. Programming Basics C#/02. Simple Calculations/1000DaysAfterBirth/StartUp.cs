namespace _1000DaysAfterBirth
{
    using System;
    using System.Globalization;

    public class StartUp
    {
        public static void Main()
        {
            string dateStr = Console.ReadLine();
            string format = "dd-MM-yyyy";
            DateTime date = DateTime.ParseExact(dateStr, format, CultureInfo.InvariantCulture).AddDays(999);

            Console.WriteLine(date.ToString(format));
        }
    }
}
