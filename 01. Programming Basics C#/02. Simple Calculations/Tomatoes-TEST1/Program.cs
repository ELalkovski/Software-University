using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tomatoes_TEST1
{
    class Program
    {
        static void Main(string[] args)
        {
            var vegetablesPrice = double.Parse(Console.ReadLine());
            var fruitsPrice = double.Parse(Console.ReadLine());
            var vegetablesKG = int.Parse(Console.ReadLine());
            var fruitsKG = int.Parse(Console.ReadLine());

            double vegetablesOUT = vegetablesPrice * vegetablesKG;
            double fruitsOUT = fruitsPrice * fruitsKG;
            double Money = (vegetablesOUT + fruitsOUT) / 1.94;
            Console.WriteLine(Money);
        }
    }
}
