using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TubesInaPool___TEST_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var V = int.Parse(Console.ReadLine());
            var P1 = int.Parse(Console.ReadLine());
            var P2 = int.Parse(Console.ReadLine());
            var H = double.Parse(Console.ReadLine());

           
            double water = P1 * H + P2 * H;

            if (water <= V)
            {
             Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.",
                 Math.Truncate((water/ V) *100),
                 Math.Truncate((P1 * H/ water) * 100),
                 Math.Truncate((P2 * H / water) * 100) );
            }
            else
            {
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.", H, water - V);
            }
        }
    }
}
