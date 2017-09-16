using System;

namespace _06.Sentence_Extractor
{
    public class SentenceExtractor
    {
        public static void Main()
        {
            var word = Console.ReadLine();
            var text = Console.ReadLine();
            var startIndex = 0;
            var endIndex = 0;

            for (int i = 0; i < text.Length; i++)
            {
                var currChar = text[i];

                if (currChar == '!' || currChar == '?' || currChar == '.')
                {
                    endIndex = i - startIndex + 1;
                    var currSentence = text.Substring(startIndex, endIndex);
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