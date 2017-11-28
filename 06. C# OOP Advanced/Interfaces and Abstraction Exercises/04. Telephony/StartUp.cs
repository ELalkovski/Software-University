namespace _04.Telephony
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string[] numbers = Console.ReadLine()
                .Split(' ');

            string[] urls = Console.ReadLine()
                .Split(' ');

            ICallable phone = new SmartPhone();

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
