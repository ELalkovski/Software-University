namespace _4.Files
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Files
    {
        public static void Main()
        {
            int lineCount = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, long>> allFiles = new Dictionary<string, Dictionary<string, long>>();

            for (int i = 0; i < lineCount; i++)
            {
                string[] input = Console.ReadLine().Split('\\');
                string[] fileData = input[input.Length - 1].Split(';');

                string root = input[0];
                string fileName = fileData[0];
                long sizeOfFile = long.Parse(fileData[1]);
                Dictionary<string, long> eachFile = new Dictionary<string, long>();

                if (!allFiles.ContainsKey(root))
                {
                    eachFile.Add(fileName, sizeOfFile);
                    allFiles.Add(root, eachFile);
                }
                else
                {
                    if (!allFiles[root].ContainsKey(fileName))
                    {
                        allFiles[root].Add(fileName, sizeOfFile);
                    }
                    else
                    {
                        allFiles[root][fileName] = sizeOfFile;                      
                    }
                }              
            }

            string[] query = Console.ReadLine().Split(' ');
            string extension = "." + query[0];
            string mainFolder = query[2];

            bool isPrinted = false;

            foreach (var root in allFiles)
            {
                foreach (var file in root.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    if (root.Key == mainFolder && file.Key.Contains(extension))
                    {
                        Console.WriteLine($"{file.Key} - {file.Value} KB");
                        isPrinted = true;
                    }
                }
            }
            if (!isPrinted)
            {
                Console.WriteLine("No");
            }
        }
    }
}
