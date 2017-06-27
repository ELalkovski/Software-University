using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sign_of_Integer_Number
{
    class Program
    {
        public static void PrintIntegerSign(int number)
        {
            if (number > 0) Console.WriteLine("The number {0} is positive.", number);
            else if (number < 0) Console.WriteLine("The number {0} is negative.", number);
            else Console.WriteLine("The number {0} is zero.", number);
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintIntegerSign(n);
        }
    }
}
