using System;
using System.Text.RegularExpressions;

namespace _07.Valid_Time
{
    public class ValidTime
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            while (input != "END")
            {
                var match = new Regex(@"^[01][0-9]:[012345][0-9]:[012345][0-9]\s[AP]M$").Match(input);
                if (match.Success)
                {
                    Console.WriteLine("valid");
                }
                else
                {
                    Console.WriteLine("invalid");
                }

                input = Console.ReadLine();
            }
        }
    }
}
