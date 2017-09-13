using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = 10;
            int symbolsPerRow = 10;

            for (int i = 1; i <= rows; i++)
            {
                Console.WriteLine(new string ('*',symbolsPerRow));
            }
        }
    }
}
