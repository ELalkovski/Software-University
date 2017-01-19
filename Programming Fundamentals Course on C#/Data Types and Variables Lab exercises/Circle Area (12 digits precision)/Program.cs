using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_Area__12_digits_precision_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a radius: ");
            double r = double.Parse(Console.ReadLine());
            double area = Math.PI * r * r;
            Console.WriteLine("Area of the circle is {0:f12}",area);
        }
    }
}
