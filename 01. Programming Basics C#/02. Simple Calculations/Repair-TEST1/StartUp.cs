namespace Repair_TEST1
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int childrenParkLength = int.Parse(Console.ReadLine());
            double tileWidth = double.Parse(Console.ReadLine());
            double tileLength = double.Parse(Console.ReadLine());
            int benchWidth = int.Parse(Console.ReadLine());
            int benchLength = int.Parse(Console.ReadLine());

            int childrenParkArea = childrenParkLength * childrenParkLength;
            int benchArea = benchWidth * benchLength;
            int clearArea = childrenParkArea - benchArea;

            double tileArea = tileWidth * tileLength;
            double tilesNeeded = clearArea / tileArea;
            double timeNeeded = tilesNeeded * 0.2;

            Console.WriteLine(tilesNeeded);
            Console.WriteLine(timeNeeded);
        }
    }
}
