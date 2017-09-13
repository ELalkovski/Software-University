namespace Most_Frequent_Number
{
    using System;
    using System.Linq;

    public class MostFrequentNumber
    {
        public static void Main()
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine(GetMostFrequentNum(array));
        }

        public static int GetMostFrequentNum(int[] array)
        {
            int frequence = 0;
            int currNum = 0;
            int bestCurrNum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                currNum = array[i];
                int count = 0;

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
    }
}
