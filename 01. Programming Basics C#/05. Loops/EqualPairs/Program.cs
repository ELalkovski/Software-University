using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int fPair = 0;
            int diff = 0;
            int secondPair = 0;
            int thirdPair = 0;
            int sum = 0;
            int allSum = 0;

            for (int rows = 1; rows <= n; rows++)
            {
                int firstNum = int.Parse(Console.ReadLine());
                int secondNum = int.Parse(Console.ReadLine());

                 sum = firstNum + secondNum;
                allSum += sum;
                if (rows > 1)
                {
                    diff = allSum - sum;
                }


            }
            Console.WriteLine(diff);
        }
    }
}
