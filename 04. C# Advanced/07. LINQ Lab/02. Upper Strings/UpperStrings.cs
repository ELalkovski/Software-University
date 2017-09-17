using System;
using System.Linq;

namespace _02.Upper_Strings
{
    using System.Collections.Generic;

    public class UpperStrings
    {
        public static void Main()
        {
           List<string> words = Console.ReadLine()
                .Split()
                .ToList();

                words.Select(w => w.ToUpper())
                .ToList()
                .ForEach(w => Console.Write(w + " "));
        }
    }
}
