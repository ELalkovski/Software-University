using System;
using System.Linq;

namespace _03.First_Name
{
    public class FirstName
    {
        public static void Main()
        {
            var names = Console.ReadLine().Split().ToList();
            var inputLetters = Console.ReadLine()
                .Split(' ').OrderBy(w => w);

            var result = string.Empty;

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
