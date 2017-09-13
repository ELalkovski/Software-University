using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int maxNumber = 0;
            int sum = 0;

            for (int userNum = 0; userNum < n; userNum++)
            {
                int numbers = int.Parse(Console.ReadLine());

                if (maxNumber <= numbers)
                {
                    maxNumber = numbers;
                    
                }
                sum = sum + numbers;
            }

            sum -= maxNumber;
            if (maxNumber == sum)
            {
                Console.WriteLine("Yes Sum = "+ maxNumber);
            }
            else
            {
                Console.WriteLine("No Diff = {0}", Math.Abs(maxNumber - sum));
            }
        }
    }
}
