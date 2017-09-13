namespace Largest_Common_End
{
    using System;

    public class LargestCommonEnd
    {
        public static void Main()
        {
            string[] array1 = Console.ReadLine()
                .Split(new [] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string[] array2 = Console.ReadLine()
                .Split(new [] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int lengthL = 0;
            int lengthR = 0;

            for (int i = 0; i < Math.Min(array1.Length, array2.Length); i++)
            {
                if (array1[i] == array2[i])
                {
                    lengthL++;
                }

                if (array1[array1.Length - 1 - i] == array2[array2.Length - 1 - i])
                {
                    lengthR++;
                }
            }

            if (lengthL >= lengthR)
            {
                Console.WriteLine(lengthL);
            }

            else
            {
                Console.WriteLine(lengthR);
            }
        }
    }
}
