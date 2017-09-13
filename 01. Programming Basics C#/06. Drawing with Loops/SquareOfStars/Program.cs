using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int rows = 1; rows <= n; rows++)
            {
                Console.Write("*");
                for (int cols = 1; cols < n; cols++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
                
            }
        }
    }
}
