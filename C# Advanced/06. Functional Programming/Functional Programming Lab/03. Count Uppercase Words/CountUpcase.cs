using System;
using System.Linq;

namespace _03.Count_Uppercase_Words
{
    public class CountUpcase
    {
        public static void Main()
        {
            Func<string, bool> checker = n => n[0] == n.ToUpper()[0];

            var words = Console.ReadLine()
                .Split(new []{" "}, StringSplitOptions.RemoveEmptyEntries);

            
            words.Where(checker)
                .ToList()
                .ForEach(n => Console.WriteLine(n));
        }
    }
}
