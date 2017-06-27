
namespace _5.Short_Words_Sorted
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class ShortWordsSorted
    {
        public static void Main()
        {
            char[] separators = { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' '};

            var inputWords = Console.ReadLine()
                .ToLower()
                .Split(separators, StringSplitOptions.RemoveEmptyEntries)
                .Where(w => w.Length < 5)
                .OrderBy(w => w)                
                .Distinct()
                .ToList();

            Console.WriteLine(string.Join(", ", inputWords));
        }
    }
}
