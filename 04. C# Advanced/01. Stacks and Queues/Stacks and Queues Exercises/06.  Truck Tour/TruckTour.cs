namespace _06.Truck_Tour
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TruckTour
    {
        static int n;
        static Queue<int[]> pumps;

        public static void Main()
        {
            /*
             Input Format: 
                The first line will contain the value of N.
                The next N lines will contain a pair of integers each, i.e. the amount of petrol that petrol pump will give and the distance between that petrol pump and the next petrol pump.

             Output Format: 
                An integer which will be the smallest index of the petrol pump from which we can start the tour.

             */


            n = int.Parse(Console.ReadLine());
            pumps = new Queue<int[]>();

            for (int i = 0; i < n; i++)
            {
                var currEntry = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();

                pumps.Enqueue(currEntry);
            }

            for (int i = 0; i < n; i++)
            {
                if (isFirstTank())
                {
                    Console.WriteLine(i);
                    break;
                }
                pumps.Enqueue(pumps.Dequeue());
            }
        }

        public static bool isFirstTank()
        {
            bool isTrue = true;
            var tankFuel = 0;

            for (int i = 0; i < n; i++)
            {
                var currPump = pumps.Dequeue();
                tankFuel += currPump[0] - currPump[1];

                if (tankFuel < 0)
                {
                    isTrue = false;
                }

                pumps.Enqueue(currPump);
            }

            return isTrue;
        }
    }
}
