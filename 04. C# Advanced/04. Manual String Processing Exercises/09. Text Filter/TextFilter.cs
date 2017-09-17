namespace _09.Text_Filter
{
    using System;
    using System.Linq;

    public class TextFilter
    {
        public static void Main()
        {
            string[] banWords = Console.ReadLine()
                .Split(new[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries);

            string text = Console.ReadLine();

            for (int i = 0; i < banWords.Length; i++)
            {
                string currWord = banWords[i];
                string replaceString = new string('*', currWord.Length);

                text = text.Replace(currWord, replaceString);
            }

            Console.WriteLine(text);
        }
    }
}
