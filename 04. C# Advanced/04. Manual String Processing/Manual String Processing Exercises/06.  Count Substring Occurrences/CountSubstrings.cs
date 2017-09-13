namespace _2.Count_substring_occurrences
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine().ToLower();
            string pattern = Console.ReadLine().ToLower();

            var counter = 0;
            int index = input.IndexOf(pattern);

            while (index != -1)
            {
                counter++;
                index = input.IndexOf(pattern, index + 1);
            }
            Console.WriteLine(counter);
        }
    }
}
