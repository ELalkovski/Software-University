using System;

namespace _15.Melrah_Shake
{
    public class MelrahShake
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var pattern = Console.ReadLine();

            while (true)
            {
                var firstPatternFoundAt = input.IndexOf(pattern);
                var secondPatternFoundAt = input.LastIndexOf(pattern);

                if (firstPatternFoundAt != secondPatternFoundAt && firstPatternFoundAt != -1 && secondPatternFoundAt != -1 && pattern != String.Empty)
                {
                    input = input.Remove(firstPatternFoundAt, pattern.Length);
                    secondPatternFoundAt -= pattern.Length;
                    input = input.Remove(secondPatternFoundAt, pattern.Length);
                    Console.WriteLine("Shaked it.");
                    var indexToRemove = pattern.Length / 2;
                    pattern = pattern.Remove(indexToRemove, 1);
                }
                else
                {
                    Console.WriteLine("No shake.");
                    Console.WriteLine(input);
                    break;
                }
               
            }
        }
    }
}
