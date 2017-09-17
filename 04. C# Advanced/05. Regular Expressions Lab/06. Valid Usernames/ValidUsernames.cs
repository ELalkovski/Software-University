namespace _06.Valid_Usernames
{
    using System;
    using System.Text.RegularExpressions;

    public class ValidUsernames
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                Match match = new Regex(@"^[\w\d-]{3,16}$").Match(input);

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
