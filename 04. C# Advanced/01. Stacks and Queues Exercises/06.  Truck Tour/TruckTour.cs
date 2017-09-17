namespace _06.Truck_Tour
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TruckTour
    {
        private static int linesCount;
        private static Queue<int[]> pumps;

        public static void Main()
        {
            /*
             Input Format: 
                The first line will contain the value of N.
                The next N lines will contain a pair of integers each, i.e. the amount of petrol that petrol pump will give and the distance between that petrol pump and the next petrol pump.

             Output Format: 
                An integer which will be the smallest index of the petrol pump from which we can start the tour.

             */


            linesCount = int.Parse(Console.ReadLine());
            pumps = new Queue<int[]>();

            for (int i = 0; i < linesCount; i++)
            {
                int[] currEntry = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();

                pumps.Enqueue(currEntry);
            }

            for (int i = 0; i < linesCount; i++)
            {
                if (IsFirstTank())
                {
                    Console.WriteLine(i);
                    break;
                }

                pumps.Enqueue(pumps.Dequeue());
            }
        }

        private static bool IsFirstTank()
        {
            bool isTrue = true;
            int tankFuel = 0;

            for (int i = 0; i < linesCount; i++)
            {
                int[] currPump = pumps.Dequeue();
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
