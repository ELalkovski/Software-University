using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasTree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            

            

            for (int rows = 0; rows <= n; rows++)
            {
                int spaces = n - rows;
                int stars = rows;
                Console.Write("{0}{1} ", new string(' ', spaces), new string('*', stars));
                Console.Write("|");
                Console.Write(" {0}", new string('*', stars));
                stars++;
                spaces--;
                Console.WriteLine();
            }
        }
    }
}
