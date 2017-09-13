using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadiansToDegrees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("rad = ");
            var rad = double.Parse(Console.ReadLine());
            var deg = rad * 180 / Math.PI;
            Console.WriteLine("deg = " + Math.Round(deg, 0));
             
        }
    }
}
