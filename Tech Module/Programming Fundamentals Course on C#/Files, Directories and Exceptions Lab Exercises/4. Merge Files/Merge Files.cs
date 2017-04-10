using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace _4.Merge_Files
{
    class MergeFiles
    {
        public static void Main()
        {
            var firstInput = File.ReadAllLines("firstInput.txt");
            var secondInput = File.ReadAllLines("secondInput.txt");

            var output = new List<string>();

            for (int i = 0; i < firstInput.Length; i++)
            {
                output.Add(firstInput[i]);
            }
            for (int i = 0; i < secondInput.Length; i++)
            {
                output.Add(secondInput[i]);
            }

            File.WriteAllLines("output.txt", output.OrderBy(x => x));
        }
    }
}
