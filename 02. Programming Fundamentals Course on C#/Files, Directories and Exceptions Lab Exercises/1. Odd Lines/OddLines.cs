namespace _1.Odd_Lines
{
    using System.Collections.Generic;
    using System.IO;

    public class OddLines
    {
        public static void Main()
        {
            string file = "Input.txt";

            string[] lines = File.ReadAllLines(file);

            List<string> oddLines = new List<string>();

            for (int i = 0; i < lines.Length; i++)
            {
                if (i % 2 != 0)
                {
                    oddLines.Add(lines[i]);
                }
            }

            File.WriteAllLines("Output.txt", oddLines);
        }
    }
}
