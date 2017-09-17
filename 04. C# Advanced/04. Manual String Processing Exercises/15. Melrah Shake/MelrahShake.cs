namespace _15.Melrah_Shake
{
    using System;

    public class MelrahShake
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string pattern = Console.ReadLine();

            while (true)
            {
                int firstPatternFoundAt = input.IndexOf(pattern);
                int secondPatternFoundAt = input.LastIndexOf(pattern);

                if (firstPatternFoundAt != secondPatternFoundAt && firstPatternFoundAt != -1 && secondPatternFoundAt != -1 && pattern != String.Empty)
                {
                    input = input.Remove(firstPatternFoundAt, pattern.Length);
                    secondPatternFoundAt -= pattern.Length;
                    input = input.Remove(secondPatternFoundAt, pattern.Length);

                    Console.WriteLine("Shaked it.");

                    int indexToRemove = pattern.Length / 2;
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
