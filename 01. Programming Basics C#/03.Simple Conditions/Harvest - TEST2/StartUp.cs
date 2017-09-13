namespace Harvest___TEST2
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int fieldLength = int.Parse(Console.ReadLine());
            double fieldWidth = double.Parse(Console.ReadLine());
            int wineNeeded = int.Parse(Console.ReadLine());
            int employees = int.Parse(Console.ReadLine());

            double grapeGathered = fieldLength * fieldWidth;
            double wineProduced = (0.4 * grapeGathered) / 2.5 ;
            double wineLeft = wineProduced - wineNeeded;

            if (wineProduced >= wineNeeded)
            {
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.",Math.Floor(wineProduced));
                Console.WriteLine("{0} liters left -> {1} liters per person.",Math.Ceiling(wineLeft), Math.Ceiling(wineLeft / employees));
            }
            else
            {
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", Math.Floor(wineNeeded - wineProduced));
            }
        }
    }
}
