namespace _05.Extract_Tags
{
    using System;
    using System.Text.RegularExpressions;

    public class ExtractTags
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            string pattern = @"<.+?>";
            Regex regex = new Regex(pattern);

            while (input != "END")
            {
                MatchCollection matches = regex.Matches(input);

                foreach (var match in matches)
                {
                    Console.WriteLine(match);
                }

                input = Console.ReadLine();
            }
        }
    }
}
