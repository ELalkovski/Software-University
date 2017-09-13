using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest___TEST2
{
    class Program
    {
        static void Main(string[] args)
        {
            var X = int.Parse(Console.ReadLine());
            var Y = double.Parse(Console.ReadLine());
            var Z = int.Parse(Console.ReadLine());
            var employees = int.Parse(Console.ReadLine());

            double grapeSUM = X * Y;
            double wine = (0.4 * grapeSUM) / 2.5 ;
            double wineLeft = wine - Z;

            if (wine >= Z)
            {
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.",Math.Floor(wine));
                Console.WriteLine("{0} liters left -> {1} liters per person.",Math.Ceiling(wineLeft), Math.Ceiling(wineLeft / employees));
            }
            else
            {
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", Math.Floor(Z - wine));
            }


        }
    }
}
