namespace _14.Letters_Change_Numbers
{
    using System;

    public class LetChangeNum
    {
        public static void Main()
        {
            string[] inputStrings = Console.ReadLine()
                .Split(new[] {' ', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            double totalSum = 0;
            string loweCaseAlphabet = "abcdefghijklmnopqrstuvwxyz";
            string upperCaseAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            double parsedNum = 0;

            for (int i = 0; i < inputStrings.Length; i++)
            {
                string currString = inputStrings[i];
                char letBeforeNum = currString[0];
                char letAfterNum = currString[currString.Length - 1];
                string num = currString.Substring(1, currString.Length - 2);

                try
                {
                    parsedNum = int.Parse(num);
                }
                catch (Exception)
                {
                    continue;;
                }

                if (upperCaseAlphabet.Contains(letBeforeNum.ToString()))
                { 
                    parsedNum /= upperCaseAlphabet.IndexOf(letBeforeNum) + 1;
                }
                else if (loweCaseAlphabet.Contains(letBeforeNum.ToString()))
                {
                    parsedNum *= loweCaseAlphabet.IndexOf(letBeforeNum) + 1;
                }

                if (upperCaseAlphabet.Contains(letAfterNum.ToString()))
                {
                    parsedNum -= upperCaseAlphabet.IndexOf(letAfterNum) + 1;
                }
                else if (loweCaseAlphabet.Contains(letAfterNum.ToString()))
                {
                    parsedNum += loweCaseAlphabet.IndexOf(letAfterNum) + 1;
                }

                totalSum += parsedNum;
            }

            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
