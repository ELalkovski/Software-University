using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOrEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            double oddSum = 0;
            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;
            double evenSum = 0;
            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;

            if (n == 0)
            {
                Console.WriteLine("OddSum=0,");
                Console.WriteLine("OddMin=No,");
                Console.WriteLine("OddMax=No,");
                Console.WriteLine("EvenSum=0,");
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");
            }
            else if (n == 1)
            {
                double nums = double.Parse(Console.ReadLine());
                Console.WriteLine("OddSum = {0}", nums);
                Console.WriteLine("OddMin = {0}", nums);
                Console.WriteLine("OddMax = {0}", nums);
                Console.WriteLine("EvenSum = 0");
                Console.WriteLine("EvenMin = No");
                Console.WriteLine("EvenMax = No");
            }

            else
            {
                for (int numbers = 1; numbers <= n ; numbers++)
                {
                    double nums = double.Parse(Console.ReadLine());


                    if (numbers % 2 == 0)
                    {
                        evenSum += nums;
                        if (nums < evenMin) evenMin = nums;
                        if (nums > evenMax) evenMax = nums;
                    }
                    else
                    {
                        oddSum += nums;

                        if (nums < oddMin) oddMin = nums;
                        if (nums > oddMax) oddMax = nums;
                    }


                }

                Console.WriteLine("OddSum={0},", oddSum);
                Console.WriteLine("OddMin={0},", oddMin);
                Console.WriteLine("OddMax={0},", oddMax);
                Console.WriteLine("EvenSum={0},", evenSum);
                Console.WriteLine("EvenMin={0},", evenMin);
                Console.WriteLine("EvenMax={0},", evenMax);
            }
            
        }
    }
}
