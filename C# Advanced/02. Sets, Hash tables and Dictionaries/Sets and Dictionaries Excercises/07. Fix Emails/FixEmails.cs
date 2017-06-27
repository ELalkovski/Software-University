namespace _07.Fix_Emails
{
    using System;
    using System.Collections.Generic;

    public class FixEmails
    {
        public static void Main()
        {
            /*
             This program recieves a sequence of strings, each on a new line, unitll the "stop" command is recieved. 
             The first string is a name of a person. On the second line it receives his email. 
             The program collects their names and emails, and removes the entries whose email’s domain ends with "us" or "uk" (case insensitive). 
             Prints all the collected people and their emails in the following format: “{name} –> {email}”

             */

            var input = Console.ReadLine();
            var usersWithEmails = new Dictionary<string, string>();
            var firstRestriction = ".us";
            var secondRestriction = ".uk";

            while (input != "stop")
            {
                var email = Console.ReadLine();
                if (!email.Contains(firstRestriction) && !email.Contains(secondRestriction))
                {
                    if (!usersWithEmails.ContainsKey(input))
                    {
                        usersWithEmails.Add(input, email);
                    }
                    else
                    {
                        usersWithEmails[input] = email;
                    }
                }
                input = Console.ReadLine();
            }

            foreach (var user in usersWithEmails)
            {
                Console.WriteLine($"{user.Key} -> {user.Value}");
            }
        }
    }
}
