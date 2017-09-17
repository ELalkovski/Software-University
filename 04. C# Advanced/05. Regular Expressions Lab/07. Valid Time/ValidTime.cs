namespace _07.Valid_Time
{
    using System;
    using System.Text.RegularExpressions;

    public class ValidTime
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                Match match = new Regex(@"^[01][0-9]:[012345][0-9]:[012345][0-9]\s[AP]M$").Match(input);

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
