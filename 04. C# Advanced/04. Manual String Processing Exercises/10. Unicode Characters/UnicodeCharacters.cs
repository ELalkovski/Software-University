namespace _10.Unicode_Characters
{
    using System;

    public class UnicodeCharacters
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                char currChar = input[i];
                string unicodeChar = @"\u" + ((int) currChar).ToString("X4");

                Console.Write(unicodeChar.ToLower());
            }

            Console.WriteLine();
        }
    }
}
