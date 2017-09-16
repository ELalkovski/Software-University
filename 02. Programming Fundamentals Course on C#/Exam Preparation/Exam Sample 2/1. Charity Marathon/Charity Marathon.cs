namespace _1.Charity_Marathon
{
    using System;

    public class CharityMarathon
    {
        public static void Main()
        {
            int marathonDays = int.Parse(Console.ReadLine());
            int participantsCount = int.Parse(Console.ReadLine());
            int lapsPerPartiipant = int.Parse(Console.ReadLine());
            int trackLength = int.Parse(Console.ReadLine());
            int trackCapacity = int.Parse(Console.ReadLine());
            double moneyPerKilometer = double.Parse(Console.ReadLine());

            int maximumRunners = marathonDays * trackCapacity;
            long totalMeters = 0;

            if (participantsCount <= maximumRunners)
            {
                totalMeters = (long)participantsCount * lapsPerPartiipant * trackLength;
            }
            else
            {
                totalMeters = (long)maximumRunners * lapsPerPartiipant * trackLength;
            }

            long totalKilometers = totalMeters / 1000;
            double moneyRaised = moneyPerKilometer * totalKilometers;
            Console.WriteLine("Money raised: {0:f2}",moneyRaised);
        }
    }
}
