using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare_Char_Arrays
{
    class Program
    {
        public static void PrintEarlierArray(char[] firstArray, char[] secondArray, char[] earlierArr)
        {
            if (GetEarlierArray(firstArray, secondArray, earlierArr))
            {
                for (int i = 0; i < earlierArr.Length; i++)
                {
                    Console.Write(earlierArr[i]);
                }
                Console.WriteLine();
                for (int i = 0; i < secondArray.Length; i++)
                {
                    Console.Write(secondArray[i]);
                }
                Console.WriteLine();
            }

            else
            {
                for (int i = 0; i < earlierArr.Length; i++)
                {
                    Console.Write(earlierArr[i]);
                }
                Console.WriteLine();
                for (int i = 0; i < firstArray.Length; i++)
                {
                    Console.Write(firstArray[i]);
                }
                Console.WriteLine();
            }
        }

        public static bool GetEarlierArray(char[] firstArray, char[] secondArray, char[] earlierArr)
        {
            bool isFirstArr = false;

            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] < secondArray[i])
                {
                    isFirstArr = true;

                    for (int j = 0; j < firstArray.Length; j++)
                    {
                        earlierArr[j] = firstArray[j];
                        if (j == firstArray.Length - 1) break;
                    }

                    break;
                }
                else if (secondArray[i] < firstArray[i])
                {
                    for (int j = 0; j < secondArray.Length; j++)
                    {
                        earlierArr[j] = secondArray[j];
                        if (j == secondArray.Length - 1) break;
                    }
                    break;
                }
                else
                {
                    for (int j = 0; j < secondArray.Length; j++)
                    {
                        earlierArr[j] = secondArray[j];
                        if (j == secondArray.Length - 1) break;
                    }
                    break;
                }
            }

            return isFirstArr;
        }

        public static void PrintShorterArray(char[] firstArray, char[] secondArray)
        {
            var shortestLength = Math.Min(firstArray.Length, secondArray.Length);
            var longeststLength = Math.Max(firstArray.Length, secondArray.Length);

            for (int i = 0; i < shortestLength; i++)
            {
                if (shortestLength == firstArray.Length)
                {
                    Console.Write(firstArray[i]);
                }
                else
                {
                    Console.Write(secondArray[i]);
                }
            }

            Console.WriteLine();

            for (int i = 0; i < longeststLength; i++)
            {
                if (longeststLength == firstArray.Length)
                {
                    Console.Write(firstArray[i]);
                }
                else
                {
                    Console.Write(secondArray[i]);
                }
            }

            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            var firstArray = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            var secondArray = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();


            var earlierArr = new char[firstArray.Length];

            if (firstArray.Length == secondArray.Length)
            {
                PrintEarlierArray(firstArray, secondArray, earlierArr);
            }
            else
            {
                PrintShorterArray(firstArray, secondArray);
            }
        }
    }
}
