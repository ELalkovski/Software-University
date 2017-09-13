using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowersOfTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 1;

            for (int nums = 0; nums <= n; nums++)
            {
                
                Console.WriteLine(num);
                num = num * 2;
            }
        }
    }
}
