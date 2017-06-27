using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Most_Frequent_Number
{
    class Program
    {
        public static int GetMostFrequentNum(int [] array)
        {
            var frequence = 0;
            var currNum = 0;
            var bestCurrNum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                currNum = array[i];
                var count = 0;

                for (int j = i; j < array.Length; j++)
                {
                    if (currNum == array[j])
                    {
                        count++;
                    }

                }

                if (count > frequence)
                {
                    bestCurrNum = currNum;
                    frequence = count;
                }
            }
            return bestCurrNum;
        }

        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine(GetMostFrequentNum(array));
        }
    }
}
