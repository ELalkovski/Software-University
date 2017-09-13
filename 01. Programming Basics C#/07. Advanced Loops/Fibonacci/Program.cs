using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int f0 = 1;
            int f1 = 1;
            var fSum = 0;
            if (n < 2)
            {
                Console.WriteLine(1);
            }
            else
            {
                for (int i = 0; i < n - 1; i++)
                {
                    fSum = f0 + f1;
                    f0 = f1;
                    f1 = fSum;
                }
                Console.WriteLine(fSum);
            }
            
        }
    }
}
