using System;
using System.Collections.Generic;

public class StartUp
{
    public static void Main()
    {
        var bankAccounts = new Dictionary<int, BankAccount>();

        var input = Console.ReadLine();

        while (input != "End")
        {
            var tokens = input.Split(' ');
            var command = tokens[0];
            var id = int.Parse(tokens[1]);

            switch (command)
            {
                case "Create":
                    if (!bankAccounts.ContainsKey(id))
                    {
                        bankAccounts.Add(id, new BankAccount());
                        bankAccounts[id].ID = id;
                    }
                    else
                    {
                        Console.WriteLine("Account already exists");
                    }
                    break;
                case "Deposit":
                    if (bankAccounts.ContainsKey(id))
                    {
                        var depositAmount = double.Parse(tokens[2]);
                        bankAccounts[id].Deposit(depositAmount);
                    }
                    else
                    {
                        Console.WriteLine("Account does not exist");
                    }
                    break;
                case "Withdraw":
                    if (bankAccounts.ContainsKey(id))
                    {
                        var withdrawAmount = double.Parse(tokens[2]);
                        if (withdrawAmount > bankAccounts[id].Balance)
                        {
                            Console.WriteLine("Insufficient balance");
                        }
                        else
                        {
                            bankAccounts[id].Withdraw(withdrawAmount);
                        }     
                    }
                    else
                    {
                        Console.WriteLine("Account does not exist");
                    }
                    break;
                case "Print":
                    if (bankAccounts.ContainsKey(id))
                    {
                        Console.WriteLine(bankAccounts[id].ToString());
                    }
                    else
                    {
                        Console.WriteLine("Account does not exist");
                    }
                    break;
            }

            input = Console.ReadLine();
        }
    }
}

