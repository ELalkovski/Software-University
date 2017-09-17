﻿namespace _08.Extract_Quatations
{
    using System;
    using System.Text.RegularExpressions;

    public class ExtractQuatations
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            Regex regex = new Regex("(\"|\')(.*?)\\1");
            MatchCollection matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Groups[2].Value);
            }
        }
    }
}
