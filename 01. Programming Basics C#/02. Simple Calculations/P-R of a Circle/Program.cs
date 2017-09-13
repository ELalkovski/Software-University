using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_R_of_a_Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = double.Parse(Console.ReadLine());
            var area = Math.PI * r * r;
            var perimeter = 2 * Math.PI * r;
            Console.WriteLine("area = " + area);
            Console.WriteLine("perimeter = " + perimeter);

        }
    }
}
