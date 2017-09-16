namespace _1.Sino_The_Walker
{
    using System;

    public class SinoTheWalker
    {
        public static void Main()
        {
            DateTime leavingTime = DateTime.Parse(Console.ReadLine());
            double steps = double.Parse(Console.ReadLine()) % 86400;
            double timeInSeconds = double.Parse(Console.ReadLine()) % 86400;
            double allTime = steps * timeInSeconds / 3600;

            Console.WriteLine("Time Arrival: {0}",(leavingTime.AddHours(allTime)).TimeOfDay);
        }
    }
}
