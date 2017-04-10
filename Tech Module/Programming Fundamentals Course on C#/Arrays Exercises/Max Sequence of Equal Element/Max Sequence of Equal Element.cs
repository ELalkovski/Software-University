using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Sequence_of_Equal_Element
{
    class Program
    {
        public static void GetBestSequence(int[] array)
        {
            var start = 0;
            var count = 0;
            var bestCount = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == array[i + 1])
                {
                    count++;

                    if (count > bestCount)
                    {
                        start = i - count;
                        bestCount = count;
                    }
                }
                else
                {
                    count = 0;
                }
            }

            for (int i = start + 1; i <= start + bestCount + 1; i++)
            {
                Console.Write("{0} ", array[i]);
            }

            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            GetBestSequence(array);
        }
    }
}
