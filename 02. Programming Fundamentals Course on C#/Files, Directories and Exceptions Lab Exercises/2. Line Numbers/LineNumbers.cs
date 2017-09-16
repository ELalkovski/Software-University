namespace _2.Line_Numbers
{
    using System;
    using System.IO;

    public class LineNumbers
    {
        public static void Main()
        {
            string file = "Input.txt";

            string[] lines = File.ReadAllLines(file);

            for (int i = 0; i < lines.Length; i++)
            {
                File.AppendAllText("output.txt", $"{i + 1}. {lines[i]}{Environment.NewLine}");
            }
        }
    }
}
