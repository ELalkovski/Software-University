using System;
using System.Text;

namespace _05.Concatenate_Strings
{
    public class ConcatStrings
    {
        public static void Main()
        {
            var wordsCount = int.Parse(Console.ReadLine());
            var sb = new StringBuilder(1000);

            for (int i = 0; i < wordsCount; i++)
            {
                sb.Append(Console.ReadLine()).Append(" ");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
