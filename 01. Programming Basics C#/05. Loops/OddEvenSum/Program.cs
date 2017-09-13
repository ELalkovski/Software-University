using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int oddSum = 0;
            int evenSum = 0;

            for (int userNum = 0; userNum < n; userNum++)
            {
                int element = int.Parse(Console.ReadLine());
                if (userNum % 2 == 0)
                {
                    oddSum += element;
                    
                }
                else
                {
                    evenSum += element;
                }

            }
            if (oddSum == evenSum)
            {
                Console.WriteLine("Yes Sum = " + oddSum);
            }
            else
            {
                Console.WriteLine("No Diff = " + Math.Abs(oddSum - evenSum));
            }

            
        }
    }
}
