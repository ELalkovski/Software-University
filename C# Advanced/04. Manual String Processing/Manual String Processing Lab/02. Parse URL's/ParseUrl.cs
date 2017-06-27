using System;
using System.Linq;

namespace _02.Parse_URL_s
{
    public class ParseUrl
    {
        public static void Main()
        {
            var url = Console.ReadLine()
                .Split(new[] {"://"}, StringSplitOptions.RemoveEmptyEntries);

            if (url.Length != 2 || !url[1].Contains('/'))
            {
                Console.WriteLine("Invalid URL");
            }
            else
            {
                var currToken = url[1];
                var length = currToken.Length;
                var protocol = url[0];
                var resourceStartIndex = url[1].IndexOf('/');

                var server = url[1].Substring(0, resourceStartIndex);
                var resource = url[1].Substring(resourceStartIndex + 1, url[1].Length - resourceStartIndex - 1);
                Console.WriteLine($"Protocol = {protocol}");
                Console.WriteLine($"Server = {server}");
                Console.WriteLine($"Resources = {resource}");
            }
        }
    }
}
