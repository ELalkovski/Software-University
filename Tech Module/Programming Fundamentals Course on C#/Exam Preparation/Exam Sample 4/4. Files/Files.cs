namespace _4.Files
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Files
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var allFiles = new Dictionary<string, Dictionary<string, long>>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split('\\');
                var fileData = input[input.Length - 1].Split(';');

                var root = input[0];
                var fileName = fileData[0];
                var sizeOfFile = long.Parse(fileData[1]);
                var eachFile = new Dictionary<string, long>();

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

            var query = Console.ReadLine().Split(' ');
            var extension = "." + query[0];
            var mainFolder = query[2];

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
