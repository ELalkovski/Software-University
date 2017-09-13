using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceOfTransport___TEST_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var km = int.Parse(Console.ReadLine());
            string dayORnight = Console.ReadLine();
            double priceCost;

            if (km < 20 && dayORnight == "day")
            {
                priceCost = 0.70 + (0.79 * km);
                Console.WriteLine(priceCost);
            }
            else if (km < 20 && dayORnight == "night")
            {
                priceCost = 0.70 + (0.90 * km);
                Console.WriteLine(priceCost);
            }
            if (km >= 20 && km < 100 && (dayORnight == "day"))
            {
                priceCost = 0.09 * km;
                Console.WriteLine(priceCost);
            }
            else if (km >= 20 && km < 100 && dayORnight == "night")
            {
                priceCost = 0.09 * km;
                Console.WriteLine(priceCost);
            }
            if (km >= 100 && dayORnight == "day")
            {
                priceCost = 0.06 * km;
                Console.WriteLine(priceCost);
            }
            else if (km >= 100 && dayORnight == "night")
            {
                priceCost = 0.06 * km;
                Console.WriteLine(priceCost);
            }

        }
    }
}
