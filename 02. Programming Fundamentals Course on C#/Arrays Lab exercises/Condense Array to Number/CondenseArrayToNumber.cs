namespace Condense_Array_to_Number
{
    using System;
    using System.Linq;

    public class CondenseArrayToNumber
    {
        public static void Main()
        {
            int [] mainArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            
            while (mainArr.Length > 1)
            {
                int[] condensedArr = new int[mainArr.Length - 1];

                for (int i = 0; i < condensedArr.Length; i++)
                {
                    condensedArr[i] = mainArr[i] + mainArr[i + 1];
                }

                mainArr = condensedArr;
            }

            Console.WriteLine(String.Join(" ", mainArr));
        }
    }
}