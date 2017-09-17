namespace _10.Use_Your_Chains__Buddy
{
    using System;
    using System.IO;
    using System.Text.RegularExpressions;

    public class Chains
    {
        public static void Main()
        {
            Console.SetIn(new StreamReader(Console.OpenStandardInput(8192)));
            string input = Console.ReadLine();

            Regex regex = new Regex("<p>(.*?)<\\/p>");
            MatchCollection matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                string whitespaces = "[^a-z0-9]";
                string reminder = match.Groups[1].Value;
                string replacedMessage = Regex.Replace(reminder, whitespaces, " ");
                replacedMessage = Regex.Replace(replacedMessage, "\\s+", " ");

                foreach(var currentLetter in replacedMessage)
                {
                    if (currentLetter >= 'a' && currentLetter <= 'm')
                    {
                        Console.Write((char)(currentLetter + 13));
                    }
                    else if (currentLetter >= 'n' && currentLetter <= 'z')
                    {
                        Console.Write((char)(currentLetter - 13));
                    }
                    else
                    {
                        Console.Write(currentLetter);
                    }
                }
            }
        }
    }
}