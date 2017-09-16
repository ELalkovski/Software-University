using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Letters_Change_Numbers
{
    public class LetChangeNum
    {
        public static void Main()
        {
            var inputStrings = Console.ReadLine()
                .Split(new[] {' ', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            double totalSum = 0;
            var loweCaseAlphabet = "abcdefghijklmnopqrstuvwxyz";
            var upperCaseAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            double parsedNum = 0;

            for (int i = 0; i < inputStrings.Length; i++)
            {
                var currString = inputStrings[i];
                var letBeforeNum = currString[0];
                var letAfterNum = currString[currString.Length - 1];
                var num = currString.Substring(1, currString.Length - 2);

                try
                {
                    parsedNum = int.Parse(num);
                }
                catch (Exception e)
                {
                    continue;;
                }

                if (upperCaseAlphabet.Contains(letBeforeNum))
                { 
                    parsedNum /= upperCaseAlphabet.IndexOf(letBeforeNum) + 1;
                }
                else if (loweCaseAlphabet.Contains(letBeforeNum))
                {
                    parsedNum *= loweCaseAlphabet.IndexOf(letBeforeNum) + 1;
                }
                if (upperCaseAlphabet.Contains(letAfterNum))
                {
                    parsedNum -= upperCaseAlphabet.IndexOf(letAfterNum) + 1;
                }
                else if (loweCaseAlphabet.Contains(letAfterNum))
                {
                    parsedNum += loweCaseAlphabet.IndexOf(letAfterNum) + 1;
                }

                totalSum += parsedNum;
            }

            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
