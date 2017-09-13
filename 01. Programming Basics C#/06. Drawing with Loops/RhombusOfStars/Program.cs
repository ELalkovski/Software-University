using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhombusOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int spaces = n - 1;
            
            

            for (int row = 1; row <= n; row++)
            {
                Console.Write(new string(' ', spaces));
                Console.Write("*");
                for (int cols = 1; cols < row; cols++)
                {
                    Console.Write(" *");

                }
                Console.WriteLine();
                spaces--;
            }
            spaces = 1;
            for (int row = 1; row <= n - 1; row++)
            {
                Console.Write(new string(' ', spaces));
                Console.Write("*");
                for (int cols = n-1; cols > row; cols--)
                {
                    Console.Write(" *");

                }
                Console.WriteLine();
                spaces++;
            }
            
        }
    }
}
