namespace _2.Line_Numbers
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


            for (int i = 0; i < lines.Length; i++)
            {
                File.AppendAllText("output.txt", $"{i + 1}. {lines[i]}{Environment.NewLine}");
            }
        }
    }
}
