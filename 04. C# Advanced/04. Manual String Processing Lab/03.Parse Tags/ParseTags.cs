namespace _03.Parse_Tags
{
    using System;

    public class ParseTags
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string openTag = "<upcase>";
            string closeTag = "</upcase>";
            int tagStartIndex = input.IndexOf(openTag);
            
            while (tagStartIndex != -1)
            {
                int tagEndIndex = input.IndexOf(closeTag);

                if (tagEndIndex == -1)
                {
                    break;
                }

                string textForChange = input.Substring(tagStartIndex, tagEndIndex - tagStartIndex + closeTag.Length);
                string changed = textForChange.Replace(openTag, "")
                    .Replace(closeTag, "").ToUpper();

                input = input.Replace(textForChange, changed);
                tagStartIndex = input.IndexOf(openTag);
            }

            Console.WriteLine(input);
        }
    }
}
