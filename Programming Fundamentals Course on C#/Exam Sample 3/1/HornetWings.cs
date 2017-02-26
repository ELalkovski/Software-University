namespace _1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class HornetWings
    {
        public static void Main()
        {
            int wingFlapsCount = int.Parse(Console.ReadLine());
            decimal distanceFor1kFlaps = decimal.Parse(Console.ReadLine());
            int endurance = int.Parse(Console.ReadLine());

            decimal travelledDistance = (wingFlapsCount / 1000) * distanceFor1kFlaps;
            long flapTime = wingFlapsCount / 100;
            long restTime = (wingFlapsCount / endurance) * 5;
            long totalTime = flapTime + restTime;
            Console.WriteLine("{0:f2} m.", travelledDistance);
            Console.WriteLine("{0} s.", totalTime);
        }
    }
}
