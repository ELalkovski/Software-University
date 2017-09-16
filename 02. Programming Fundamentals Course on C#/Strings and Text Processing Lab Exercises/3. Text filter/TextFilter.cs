namespace _3.Text_filter
{
    using System;

    public class TextFilter
    {
        public static void Main()
        {
            char[] separators = new [] { ',', ' ' };
            string[] banWords = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string inputText = Console.ReadLine();

            foreach (var banWord in banWords)
            {
                if (inputText.Contains(banWord))
                {
                    inputText = inputText.Replace(banWord, new string('*', banWord.Length));
                }
            }

            Console.WriteLine(inputText);
        }
    }
}
