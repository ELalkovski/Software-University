using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.Character_Multiplier
{
    public class CharacterMultiplier
    {

        public static int CharMultiplier (string firstStr, string secondStr)
        {
            var longestLength = Math.Max(firstStr.Length, secondStr.Length);
            var sum = 0;

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

        public static void Main()
        {
            var input = Console.ReadLine().Split(' ');
            var firstStr = input[0];
            var secondStr = input[1];
            Console.WriteLine(CharMultiplier(firstStr, secondStr));
        }
    }
}
