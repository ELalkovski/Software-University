namespace _06.Sentence_Extractor
{
    using System;

    public class SentenceExtractor
    {
        public static void Main()
        {
            string word = Console.ReadLine();
            string text = Console.ReadLine();

            int startIndex = 0;
            int endIndex = 0;

            for (int i = 0; i < text.Length; i++)
            {
                char currChar = text[i];

                if (currChar == '!' || currChar == '?' || currChar == '.')
                {
                    endIndex = i - startIndex + 1;
                    string currSentence = text.Substring(startIndex, endIndex);

                    if (currSentence.Contains(" " + word + " "))
                    {
                        Console.WriteLine(currSentence);
                    }

                    startIndex = i + 1;
                }
            }
        }
    }
}