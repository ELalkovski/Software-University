namespace _05.Concatenate_Strings
{
    using System;
    using System.Text;

    public class ConcatStrings
    {
        public static void Main()
        {
            int wordsCount = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder(1000);

            for (int i = 0; i < wordsCount; i++)
            {
                sb.Append(Console.ReadLine()).Append(" ");
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
