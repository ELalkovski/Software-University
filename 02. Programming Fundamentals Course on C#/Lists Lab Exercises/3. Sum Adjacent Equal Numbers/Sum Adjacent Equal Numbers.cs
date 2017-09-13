using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Sum_Adjacent_Equal_Numbers
{
    class SumAdjacentEqualNumbers
    {
        public static void SumAdjacentEquals ( List<double> inputList)
        {
            for (int i = 0; i < inputList.Count - 1;)
            {
                if (inputList[i] == inputList[i + 1])
                {
                    inputList[i] += inputList[i + 1];
                    inputList.RemoveAt(i + 1);
                    i--;

                    if (i < 0)
                    {
                        i = 0;
                    }
                }
                else
                {
                    i++;
                }
            }

            
        }

        static void Main(string[] args)
        {
            var inputList = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            SumAdjacentEquals(inputList);

            Console.WriteLine(string.Join(" ", inputList));
        }
    }
}
