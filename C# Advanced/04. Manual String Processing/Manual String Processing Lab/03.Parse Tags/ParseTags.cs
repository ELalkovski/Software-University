using System;

namespace _03.Parse_Tags
{
    public class ParseTags
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var openTag = "<upcase>";
            var closeTag = "</upcase>";
            var tagStartIndex = input.IndexOf(openTag);
            
            while (tagStartIndex != -1)
            {
                var tagEndIndex = input.IndexOf(closeTag);
                if (tagEndIndex == -1)
                {
                    break;
                }
                var textForChange = input.Substring(tagStartIndex, tagEndIndex - tagStartIndex + closeTag.Length);
                var changed = textForChange.Replace(openTag, "")
                    .Replace(closeTag, "").ToUpper();
                input = input.Replace(textForChange, changed);
                tagStartIndex = input.IndexOf(openTag);
            }
            Console.WriteLine(input);
        }
    }
}
