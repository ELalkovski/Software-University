using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstInput = Console.ReadLine();
            string secondInput = Console.ReadLine();

            var firstArray = firstInput.Split(' ').Select(int.Parse).ToArray();
            var secondArray = secondInput.Split(' ').Select(int.Parse).ToArray();

            var maxArrayLenght = Math.Max(firstArray.Length, secondArray.Length);

            for (int i = 0; i < maxArrayLenght; i++)
            {
                var printSum = (firstArray[i % firstArray.Length]) + (secondArray[i % secondArray.Length]);

                if (i > firstArray.Length && i>= secondArray.Length)
                {
                    break;
                }

                Console.Write("{0} ",printSum);
            }

            Console.WriteLine();
        }
    }
}
