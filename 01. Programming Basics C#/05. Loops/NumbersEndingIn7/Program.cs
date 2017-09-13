using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersEndingIn7
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int num = 0; num <= 1000; num++)
            {
                if (num % 10 == 7)
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
}
