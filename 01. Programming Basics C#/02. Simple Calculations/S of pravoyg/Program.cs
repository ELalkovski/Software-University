using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S_of_pravoyg
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double width = Math.Max(x1, x2) - Math.Min(x1, x2);
            double hight = Math.Max(y1, y2) - Math.Min(y1, y2);
            Console.WriteLine("Area = {0}", width * hight);
            Console.WriteLine("Perimeter = {0}", 2 * (width + hight));
            
        }
    }
}
