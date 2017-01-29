using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pairs_by_Difference
{
    class Program
    {
        public static int GetSumPairsNumber(int [] arrayInput, int differenceInput)
        {
            int countSumPairs = 0;

            for (int i = 0; i < arrayInput.Length; i++)
            {
                for (int j = i + 1; j < arrayInput.Length; j++)
                {
                    if (Math.Abs(arrayInput[i] - arrayInput[j]) == differenceInput)
                    {
                        countSumPairs++;
                    }
                }
            }

            return countSumPairs;
        }

        static void Main(string[] args)
        {
            var arrayInput = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int differenceInput = int.Parse(Console.ReadLine());
            
            Console.WriteLine(GetSumPairsNumber(arrayInput, differenceInput));
        }
    }
}
