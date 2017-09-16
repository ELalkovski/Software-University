namespace _4.Fix_Emails
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FixEmails
    {
        public static void Main()
        {
            Dictionary<string, string> emails = new Dictionary<string, string>();

            string inputName = Console.ReadLine();

            AddEmails(emails, inputName);
            PrintMails(emails);
        }

        public static void AddEmails(Dictionary<string, string> emails, string inputName)
        {
            while (!inputName.Equals("stop"))
            {
                string mail = Console.ReadLine();

                if (emails.ContainsKey(inputName))
                {
                    emails[inputName] = mail;
                }
                else
                {
                    emails.Add(inputName, mail);
                }

                inputName = Console.ReadLine();
            }
        }

        public static void PrintMails(Dictionary<string, string> emails)
        {
            foreach (var item in emails)
            {
                List<string> domain = item.Value.Split('.').ToList();

                if (domain[1] != "us" && domain[1] != "uk")
                {
                    Console.WriteLine("{0} -> {1}", item.Key, item.Value);
                }
            }
        }
    }
}
