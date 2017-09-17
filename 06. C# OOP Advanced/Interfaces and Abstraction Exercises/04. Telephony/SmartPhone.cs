namespace _04.Telephony
{
    using System.Text;
    using System.Linq;

    public class SmartPhone : ICallable, IBrowseble
    {

        public string CallNumber(string number)
        {
            var sb = new StringBuilder();
            bool hasLetter = number.Any(char.IsLetter);

            
            if (!hasLetter)
            {
                sb.Append($"Calling... {number}");
            }
            else
            {
                sb.Append("Invalid number!");
            }

            return sb.ToString();
        }

        public string BrowseTheWeb(string url)
        {
            var sb = new StringBuilder();
            bool hasDigit = url.Any(char.IsDigit);

            if (!hasDigit)
            {
                sb.Append($"Browsing: {url}!");
            }
            else
            {
                sb.Append("Invalid URL!");
            }

            return sb.ToString();
        }
    }
}
