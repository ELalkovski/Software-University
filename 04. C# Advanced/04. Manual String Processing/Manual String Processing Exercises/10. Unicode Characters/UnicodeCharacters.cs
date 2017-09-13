using System;

namespace _10.Unicode_Characters
{
    public class UnicodeCharacters
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                var currChar = input[i];
                var unicodeChar = @"\u" + ((int) currChar).ToString("X4");
                Console.Write(unicodeChar.ToLower());
            }
            Console.WriteLine();
        }
    }
}
