using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repair_TEST1
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var w = double.Parse(Console.ReadLine());
            var l = double.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var o = int.Parse(Console.ReadLine());

            int areaPloshtadka = n * n;
            int areaPeika = m * o;
            int areaPokrivane = areaPloshtadka - areaPeika;

            double areaPlochki = w * l;
            double PlochkiNeeded = areaPokrivane / areaPlochki;
            double timeNeeded = PlochkiNeeded * 0.2;

            Console.WriteLine(PlochkiNeeded);
            Console.WriteLine(timeNeeded);


        }
    }
}
