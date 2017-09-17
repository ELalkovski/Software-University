namespace _12.Little_John
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class LittleJohn
    {
        public static void Main()
        {
            Regex sRegex = new Regex(@">----->");
            Regex mRegex = new Regex(@">>----->");
            Regex lRegex = new Regex(@">>>----->>");
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < 4; i++)
            {
                string inputLine = Console.ReadLine();
                sb.AppendLine(inputLine);
            }

            string arrowQuiver = sb.ToString();
            int largeArrowsCount = lRegex.Matches(arrowQuiver).Count;
            arrowQuiver = lRegex.Replace(arrowQuiver, " ", largeArrowsCount);

            int mediumArrowsCount = mRegex.Matches(arrowQuiver).Count;
            arrowQuiver = mRegex.Replace(arrowQuiver, " ", mediumArrowsCount);

            int smallArrowsCount = sRegex.Matches(arrowQuiver).Count;
            arrowQuiver = sRegex.Replace(arrowQuiver, " ", smallArrowsCount);

            sb.Clear();
            sb.Append(smallArrowsCount).Append(mediumArrowsCount).Append(largeArrowsCount);

            string binaryNum = Convert.ToString(int.Parse(sb.ToString()), 2);
            string reversedBinary = new string(binaryNum.ToCharArray().Reverse().ToArray());
            sb.Clear();
            StringBuilder finalBinary = sb.Append(binaryNum).Append(reversedBinary);

            long result = Convert.ToInt64(finalBinary.ToString(), 2);
            Console.WriteLine(result);
        }
    }
}
