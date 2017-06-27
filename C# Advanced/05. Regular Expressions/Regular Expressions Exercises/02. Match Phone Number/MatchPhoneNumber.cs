using System;
using System.Text.RegularExpressions;

namespace _02.Match_Phone_Number
{
    public class MatchPhoneNumber
    {
        public static void Main()
        {
            var inputNumber = Console.ReadLine();

            while (inputNumber != "end")
            {
                Console.WriteLine(new Regex(@"^\+359(\s{1})2(\s{1})[0-9]{3}(\s{1})[0-9]{4}$|^\+359(-{1})2(-{1})[0-9]{3}(-{1})[0-9]{4}$").Match(inputNumber));
                inputNumber = Console.ReadLine();
            }
        }
    }
}