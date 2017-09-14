namespace Day_of_Week
{
    using System;

    public class DayOfWeek
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            if (number > 0 && number <= 7)
            {
                Console.WriteLine(daysOfWeek[number - 1]);
            }
            else
            {
                Console.WriteLine("Invalid Day!");
            }
        }
    }
}
