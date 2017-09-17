namespace _11.Parking_Lot
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ParkingSystem
    {
        private static int rows;
        private static int cols;
        private static HashSet<string> parkedSpots = new HashSet<string>();

        public static void Main()
        {
            int[] parkingDimensions = Console.ReadLine()
                .Split(new []{' '},StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

             rows = parkingDimensions[0];
             cols = parkingDimensions[1];


            string input = Console.ReadLine();

            while (input != "stop")
            {
                int[] parkingTokens = input
                    .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int entryRow = parkingTokens[0];
                int wantedRow = parkingTokens[1];
                int wantedCol = parkingTokens[2];

                string spotCoordinates = string.Format("{0},{1}", wantedRow, wantedCol);

                if (!parkedSpots.Contains(spotCoordinates))
                {
                    parkedSpots.Add(spotCoordinates);
                    PrintResult(true, entryRow, wantedRow, wantedCol);
                }
                else
                {
                    bool found = false;
                    int loops = Math.Max(wantedCol - 1, cols - wantedCol);
                    int newCol = 0;

                    for (int i = 1; i < loops; i++)
                    {
                        var leftSpot = string.Format("{0},{1}", wantedRow, wantedCol - i);
                        var rightSpot = string.Format("{0},{1}", wantedRow, wantedCol + i);

                        if (!parkedSpots.Contains(leftSpot) && wantedCol - i > 0)
                        {
                            newCol = wantedCol - i;
                            found = true;
                            parkedSpots.Add(leftSpot);

                            break;
                        }

                        if (!parkedSpots.Contains(rightSpot) && wantedCol + i < cols)
                        {
                            newCol = wantedCol + i;
                            found = true;
                            parkedSpots.Add(rightSpot);

                            break;
                        }
                    }

                    PrintResult(found, entryRow, wantedRow, newCol);
                }

                input = Console.ReadLine();
            }
        }

        private static void PrintResult(bool found, int entryRow, int wantedRow, int wantedCol)
        {
            if (found)
            {
                int distance = CalculateDistane(entryRow, wantedRow, wantedCol);
                Console.WriteLine(distance);
            }
            else
            {
                Console.WriteLine("Row {0} full", wantedRow);
            }
        }

        private static int CalculateDistane(int entryRow, int wantedRow, int wantedCol)
        {
            return Math.Abs(entryRow - wantedRow) + wantedCol + 1;
        }
    }
}
