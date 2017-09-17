namespace _03.First_Name
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FirstName
    {
        public static void Main()
        {
            List<string> names = Console.ReadLine()
                .Split()
                .ToList();
            IOrderedEnumerable<string> inputLetters = Console.ReadLine()
                .Split(' ').OrderBy(w => w);

            string result = string.Empty;

            foreach (var letter in inputLetters)
            {
                result = names.Where(w => w.ToLower()
                        .StartsWith(letter.ToLower()))
                        .FirstOrDefault();

                if (result != null)
                {
                    Console.WriteLine(result);

                    return;
                }
            }

            Console.WriteLine("No match");
        }
    }
}
