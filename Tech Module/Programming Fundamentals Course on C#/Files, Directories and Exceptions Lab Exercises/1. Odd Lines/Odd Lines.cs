namespace _1.Odd_Lines
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;

    class Program
    {
        public static void Main()
        {
            var file = "Input.txt";

            var lines = File.ReadAllLines(file);

            var oddLines = new List<string>();

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
