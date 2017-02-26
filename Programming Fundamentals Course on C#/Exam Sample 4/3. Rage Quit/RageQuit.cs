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
            var pattern = @"(\D+)(\d+)";
            var input = Console.ReadLine();

            var regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);
            StringBuilder output = new StringBuilder();


            foreach (Match group in matches)
            {
                var uniqueSymbols = group.Groups[1].Value.ToUpper();
                var repeat = int.Parse(group.Groups[2].Value);

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
