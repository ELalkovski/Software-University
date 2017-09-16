using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace _10.Use_Your_Chains__Buddy
{
    public class Chains
    {
        public static void Main()
        {
            Console.SetIn(new StreamReader(Console.OpenStandardInput(8192)));
            var input = Console.ReadLine();
            var regex = new Regex("<p>(.*?)<\\/p>");

            var matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                var whitespaces = "[^a-z0-9]";
                var reminder = match.Groups[1].Value;
                var replacedMessage = Regex.Replace(reminder, whitespaces, " ");
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