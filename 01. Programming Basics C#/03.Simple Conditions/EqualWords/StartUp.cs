namespace EqualWords
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string word1 = Console.ReadLine();
            word1 = word1.ToLower();

            string word2 = Console.ReadLine();
            word2 = word2.ToLower();

            if (word1 == word2)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
