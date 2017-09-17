namespace _04.Telephony
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ');

            var urls = Console.ReadLine()
                .Split(' ');

            var phone = new SmartPhone();

            foreach (var number in numbers)
            {
                Console.WriteLine(phone.CallNumber(number));
            }
            foreach (var url in urls)
            {
                Console.WriteLine(phone.BrowseTheWeb(url));
            }
        }
    }
}
