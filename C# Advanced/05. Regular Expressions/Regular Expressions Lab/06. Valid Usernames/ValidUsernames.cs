using System;
using System.Text.RegularExpressions;

namespace _06.Valid_Usernames
{
    public class ValidUsernames
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            while (input != "END")
            {
                var match = new Regex(@"^[\w\d-]{3,16}$").Match(input);
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
