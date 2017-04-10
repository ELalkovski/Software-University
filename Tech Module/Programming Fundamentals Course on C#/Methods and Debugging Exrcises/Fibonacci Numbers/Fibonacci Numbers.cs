using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Numbers
{
    class Program
    {
        public static int FibonacciNum (int n)
        {
            int firstNum = 0;
            int secondNum = 1;
            int nextNum = 1;

            for (int i = 1; i <= n; i++)
            {
                nextNum = firstNum + secondNum;
                firstNum = secondNum;
                secondNum = nextNum;
                
            }
            return nextNum;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(FibonacciNum(n));
        }
    }
}
