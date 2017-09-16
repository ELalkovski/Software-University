namespace _4.Merge_Files
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class MergeFiles
    {
        public static void Main()
        {
            string[] firstInput = File.ReadAllLines("firstInput.txt");
            string[] secondInput = File.ReadAllLines("secondInput.txt");

            List<string> output = new List<string>();

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
