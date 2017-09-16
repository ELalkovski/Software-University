namespace _7.Replace_a_Tag
{
    using System;
    using System.Text.RegularExpressions;

    public class ReplaceTag
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            while (input != "end")
            {
                string pattern = @"<a.*?href.*?=(.*)>(.*?)<\/a>";
                string replacePattern = @"[URL href=$1]$2[/URL]";
                string replaced = Regex.Replace(input, pattern, replacePattern);

                Console.WriteLine(replaced);
                input = Console.ReadLine();
            }
        }
    }
}
