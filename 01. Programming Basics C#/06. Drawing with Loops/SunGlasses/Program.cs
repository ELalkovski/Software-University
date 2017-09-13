using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunGlasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int horisontalFrame = 2 * n;
            int spaces = n;

            Console.Write("{0}{1}{0}", new string('*', horisontalFrame), new string(' ', spaces));
            Console.WriteLine();

            for (int verticalF = 1; verticalF <= n - 2; verticalF++)
            {
                Console.Write("*{0}*", new string('/', (2 * n) - 2));
                if ((n % 2) == 0 && verticalF == (n - 2)/2 )
                {
                    Console.Write("{0}", new string('|', spaces));
                }
                else if ((n % 2) == 1 && verticalF == ((n - 2) / 2)+1)
                {
                    Console.Write("{0}", new string('|', spaces));
                }
                else
                {
                    Console.Write("{0}", new string(' ', spaces));
                }
                
                Console.Write("*{0}*", new string('/', (2 * n) - 2));
                Console.WriteLine();

            }
            Console.Write("{0}{1}{0}", new string('*', horisontalFrame), new string(' ', spaces));
            Console.WriteLine();
        }
    }
}
