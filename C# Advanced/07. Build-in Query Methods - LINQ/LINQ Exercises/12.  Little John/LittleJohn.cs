using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _12.Little_John
{
    public class LittleJohn
    {
        public static void Main()
        {
            var sRegex = new Regex(@">----->");
            var mRegex = new Regex(@">>----->");
            var lRegex = new Regex(@">>>----->>");
            var sb = new StringBuilder();

            for (int i = 0; i < 4; i++)
            {
                var inputLine = Console.ReadLine();
                sb.AppendLine(inputLine);
            }

            var arrowQuiver = sb.ToString();
            var largeArrowsCount = lRegex.Matches(arrowQuiver).Count;
            arrowQuiver = lRegex.Replace(arrowQuiver, " ", largeArrowsCount);

            var mediumArrowsCount = mRegex.Matches(arrowQuiver).Count;
            arrowQuiver = mRegex.Replace(arrowQuiver, " ", mediumArrowsCount);

            var smallArrowsCount = sRegex.Matches(arrowQuiver).Count;
            arrowQuiver = sRegex.Replace(arrowQuiver, " ", smallArrowsCount);

            sb.Clear();
            sb.Append(smallArrowsCount).Append(mediumArrowsCount).Append(largeArrowsCount);
            var binaryNum = Convert.ToString(int.Parse(sb.ToString()), 2);
            var reversedBinary = new string(binaryNum.ToCharArray().Reverse().ToArray());
            sb.Clear();
            var finalBinary = sb.Append(binaryNum).Append(reversedBinary);

            var result = Convert.ToInt64(finalBinary.ToString(), 2);
            Console.WriteLine(result);
        }
    }
}
