using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fastPrimeCheckerRefactor
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int searchedNum = 2; searchedNum <= num; searchedNum++)
            {
                bool isPrime = true;
                for (int checkNum = 2; checkNum <= Math.Sqrt(searchedNum); checkNum++)
                {
                    if (searchedNum % checkNum == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{searchedNum} -> {isPrime}");

            }
        }
    }
}
