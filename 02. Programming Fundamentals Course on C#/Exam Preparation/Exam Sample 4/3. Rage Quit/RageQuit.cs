namespace _3.Rage_Quit
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class RageQuit
    {
        public static void Main()
        {
            string pattern = @"(\D+)(\d+)";
            string input = Console.ReadLine();

            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);
            StringBuilder output = new StringBuilder();
            
            foreach (Match group in matches)
            {
                string uniqueSymbols = group.Groups[1].Value.ToUpper();
                int repeat = int.Parse(group.Groups[2].Value);

                for (int i = 0; i < repeat; i++)
                {
                    output.Append(uniqueSymbols);
                }
            }

            Console.WriteLine("Unique symbols used: {0}",output.ToString().Distinct().Count());
            Console.WriteLine(output);
        }
    }
}
