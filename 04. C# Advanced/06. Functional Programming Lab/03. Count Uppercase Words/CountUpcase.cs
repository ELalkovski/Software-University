namespace _03.Count_Uppercase_Words
{
    using System;
    using System.Linq;

    public class CountUpcase
    {
        public static void Main()
        {
            Func<string, bool> checker = n => n[0] == n.ToUpper()[0];

            string[] words = Console.ReadLine()
                .Split(new []{" "}, StringSplitOptions.RemoveEmptyEntries);

            
            words.Where(checker)
                .ToList()
                .ForEach(n => Console.WriteLine(n));
        }
    }
}
