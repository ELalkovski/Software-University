namespace Sum_Arrays
{
    using System;
    using System.Linq;

    public class SumArrays
    {
        public static void Main()
        {
            string firstInput = Console.ReadLine();
            string secondInput = Console.ReadLine();

            int[] firstArray = firstInput
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int[] secondArray = secondInput
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int maxArrayLenght = Math.Max(firstArray.Length, secondArray.Length);

            for (int i = 0; i < maxArrayLenght; i++)
            {
                int printSum = (firstArray[i % firstArray.Length]) + (secondArray[i % secondArray.Length]);

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
