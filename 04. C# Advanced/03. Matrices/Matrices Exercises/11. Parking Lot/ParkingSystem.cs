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
            var parkingDimensions = Console.ReadLine()
                .Split(new []{' '},StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

             rows = parkingDimensions[0];
             cols = parkingDimensions[1];


            var input = Console.ReadLine();

            while (input != "stop")
            {
                var parkingTokens = input
                    .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                var entryRow = parkingTokens[0];
                var wantedRow = parkingTokens[1];
                var wantedCol = parkingTokens[2];

                var spotCoordinates = string.Format("{0},{1}", wantedRow, wantedCol);

                if (!parkedSpots.Contains(spotCoordinates))
                {
                    parkedSpots.Add(spotCoordinates);
                    PrintResult(true, entryRow, wantedRow, wantedCol);

                }
                else
                {
                    bool found = false;
                    var loops = Math.Max(wantedCol - 1, cols - wantedCol);
                    var newCol = 0;

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
                var distance = CalculateDistane(entryRow, wantedRow, wantedCol);
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
