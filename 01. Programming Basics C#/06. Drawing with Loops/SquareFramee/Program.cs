using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareFramee
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.Write("+");
            for (int i = 0; i < n-2; i++)
            {
                Console.Write(" -");
            }
            Console.Write(" +");
            Console.WriteLine();

            for (int a = 0; a < n - 2; a++)
            {
                Console.Write("|");
                for (int j = 0; j < n - 2; j++)
                {
                    Console.Write(" -");
                }
                Console.Write(" |");
                Console.WriteLine();
            }
            Console.Write("+");
            for (int b = 0; b < n - 2; b++)
            {
                Console.Write(" -");
            }
            Console.Write(" +");
            Console.WriteLine();


        }
    }
}
