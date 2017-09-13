namespace Rotate_and_Sum
{
    using System;
    using System.Linq;

    public class RotateAndSum
    {
        public static void Main()
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rotationCount = int.Parse(Console.ReadLine());
            int[] sums = new int[array.Length];


            for (int i = 0; i < rotationCount; i++)
            {
                int temp = array[array.Length - 1];

                for (int j = array.Length - 1; j >= 1; j--)
                {
                    array[j] = array[j - 1];
                }

                array[0] = temp;

                for (int s = 0; s < array.Length; s++)
                {
                    sums[s] += array[s];
                }
            }

            for (int i = 0; i < sums.Length; i++)
            {
                Console.Write("{0} ", sums[i]);
            }

            Console.WriteLine();
        }
    }
}
