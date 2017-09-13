namespace PriceOfTransport___TEST_2
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int km = int.Parse(Console.ReadLine());
            string dayOrNight = Console.ReadLine();
            double priceCost;

            if (km < 20 && dayOrNight == "day")
            {
                priceCost = 0.70 + (0.79 * km);
                Console.WriteLine(priceCost);
            }
            else if (km < 20 && dayOrNight == "night")
            {
                priceCost = 0.70 + (0.90 * km);
                Console.WriteLine(priceCost);
            }
            if (km >= 20 && km < 100 && (dayOrNight == "day"))
            {
                priceCost = 0.09 * km;
                Console.WriteLine(priceCost);
            }
            else if (km >= 20 && km < 100 && dayOrNight == "night")
            {
                priceCost = 0.09 * km;
                Console.WriteLine(priceCost);
            }

            if (km >= 100 && dayOrNight == "day")
            {
                priceCost = 0.06 * km;
                Console.WriteLine(priceCost);
            }
            else if (km >= 100 && dayOrNight == "night")
            {
                priceCost = 0.06 * km;
                Console.WriteLine(priceCost);
            }
        }
    }
}
