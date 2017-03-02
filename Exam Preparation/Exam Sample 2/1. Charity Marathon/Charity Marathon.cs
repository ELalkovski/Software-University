namespace _1.Charity_Marathon
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    public class CharityMarathon
    {
        public static void Main()
        {
            var marathonDays = int.Parse(Console.ReadLine());
            var participantsCount = int.Parse(Console.ReadLine());
            var lapsPerPartiipant = int.Parse(Console.ReadLine());
            var trackLength = int.Parse(Console.ReadLine());
            var trackCapacity = int.Parse(Console.ReadLine());
            double moneyPerKilometer = double.Parse(Console.ReadLine());

            var maximumRunners = marathonDays * trackCapacity;
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
            var moneyRaised = moneyPerKilometer * totalKilometers;
            Console.WriteLine("Money raised: {0:f2}",moneyRaised);
        }
    }
}
