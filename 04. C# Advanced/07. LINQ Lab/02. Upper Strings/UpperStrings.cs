using System;
using System.Linq;

namespace _02.Upper_Strings
{
    public class UpperStrings
    {
        public static void Main()
        {
           
                var words = Console.ReadLine()
                .Split()
                .ToList();

                words.Select(w => w.ToUpper())
                .ToList()
                .ForEach(w => Console.Write(w + " "));
        }
    }
}
