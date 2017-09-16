namespace _04.Character_Multiplier
{
    using System;

    public class CharacterMultiplier
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            string firstStr = input[0];
            string secondStr = input[1];

            Console.WriteLine(CharMultiplier(firstStr, secondStr));
        }

        private static int CharMultiplier(string firstStr, string secondStr)
        {
            int longestLength = Math.Max(firstStr.Length, secondStr.Length);
            int sum = 0;

            for (int i = 0; i < longestLength; i++)
            {
                if (firstStr.Length == secondStr.Length)
                {
                    sum += (int)(firstStr[i]) * (int)(secondStr[i]);
                }
                else
                {
                    if (firstStr.Length > secondStr.Length)
                    {
                        if (secondStr.Length <= i)
                        {
                            sum += (int)(firstStr[i]);
                        }
                        else
                        {
                            sum += (int)(firstStr[i]) * (int)(secondStr[i]);
                        }
                    }
                    else
                    {
                        if (firstStr.Length <= i)
                        {
                            sum += (int)(secondStr[i]);
                        }
                        else
                        {
                            sum += (int)(firstStr[i]) * (int)(secondStr[i]);
                        }
                    }
                }
            }

            return sum;
        }
    }
}
