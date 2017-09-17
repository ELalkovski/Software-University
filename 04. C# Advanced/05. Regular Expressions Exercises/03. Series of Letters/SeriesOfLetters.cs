using System;
using System.Text.RegularExpressions;

namespace _03.Series_of_Letters
{
    public class SeriesOfLetters
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            Regex regex = new Regex(@"([A-Za-z])\1+");

            Console.WriteLine(regex.Replace(input, "$1"));
        }
    }
}