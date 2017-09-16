namespace _2.Randomize_Words
{
    using System;

    public class RandomizeWords
    {
        public static void Main()
        {
            string[] words = Console.ReadLine().Split(' ');
            Random random = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                string currWord = words[i];
                int randomIndex = random.Next(0, words.Length);
                string tempWord = words[randomIndex];
                words[i] = tempWord;
                words[randomIndex] = currWord;
            }

            Console.WriteLine(string.Join(Environment.NewLine, words));
        }
    }
}
