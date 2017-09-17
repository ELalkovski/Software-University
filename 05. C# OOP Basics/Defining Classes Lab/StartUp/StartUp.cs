using System;
using System.Collections.Generic;

public class StartUp
{
    public static void Main()
    {
        string input = Console.ReadLine();

        Dictionary<int, BankAccount> bankAccounts = new Dictionary<int, BankAccount>();

        while (input != "End")
        {
            string[] tokens = input.Split(' ');
            string command = tokens[0];
            int id = int.Parse(tokens[1]);

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
                        double withdrawAmount = double.Parse(tokens[2]);

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

