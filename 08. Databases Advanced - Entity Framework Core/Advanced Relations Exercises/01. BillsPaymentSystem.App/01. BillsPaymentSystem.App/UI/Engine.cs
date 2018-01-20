namespace _01._BillsPaymentSystem.App.UI
{
    using System;
    using System.Linq;
    using System.Text;
    using Microsoft.EntityFrameworkCore;
    using P01_BillsPaymentSystem.Data;
    using P01_BillsPaymentSystem.Data.Models;

    public class Engine
    {
        private const string StopCommand = "Exit";
        private const string EnterUserIdMessage = "Please Enter UserId to See his Details or Type Exit to Quit the Program: ";
        private const string ContinueMessage = "Do you want to continue Y/N: ";

        public void Run()
        {
            Console.Write(EnterUserIdMessage);
            string command = Console.ReadLine();

            while (command != StopCommand)
            {
                int userId = int.Parse(command);

                using (var db = new BillsPaymentSystemContext())
                {
                    User user = db.Users
                        .Include(u => u.PaymentMethods)
                        .ThenInclude(u => u.CreditCard)
                        .Include(u => u.PaymentMethods)
                        .ThenInclude(u => u.BankAccount)
                        .FirstOrDefault(u => u.UserId == userId);

                    Console.WriteLine(this.TryPrintUserDetails(userId, user));
                }

                Console.Write(ContinueMessage);
                string continueCommand = Console.ReadLine().ToLower();

                if (continueCommand.Equals("y"))
                {
                    Console.Clear();
                    Console.Write(EnterUserIdMessage);
                    command = Console.ReadLine();
                    continue;
                }

                break;
            }
        }

        public void PayBills(int userId, decimal amount)
        {
            using (var db = new BillsPaymentSystemContext())
            {
                User user = db.Users
                    .Include(u => u.PaymentMethods)
                    .ThenInclude(pm => pm.BankAccount)
                    .Include(u => u.PaymentMethods)
                    .ThenInclude(pm => pm.CreditCard)
                    .FirstOrDefault(u => u.UserId == userId);

                decimal totalFunds = 0.0m;

                totalFunds += user.PaymentMethods
                    .Where(pm => pm.BankAccountId != null)
                    .OrderBy(pm => pm.BankAccountId)
                    .Sum(ba => ba.BankAccount.Balance);

                if (totalFunds >= amount)
                {
                    foreach (var bankAccount in user.PaymentMethods.Where(pm => pm.BankAccountId != null))
                    {
                        decimal moneyToWithdraw = Math.Min(bankAccount.BankAccount.Balance, amount);
                        amount -= moneyToWithdraw;
                        bankAccount.BankAccount.Withdraw(moneyToWithdraw);

                        if (amount == 0)
                        {
                            return;
                        }
                    }
                }

                totalFunds += user.PaymentMethods
                    .Where(pm => pm.CreditCardId != null)
                    .OrderBy(pm => pm.CreditCardId)
                    .Sum(pm => pm.CreditCard.MoneyOwned);

                if (totalFunds >= amount)
                {
                    foreach (var bankAccount in user.PaymentMethods.Where(pm => pm.BankAccountId != null))
                    {
                        decimal moneyToWithdraw = Math.Min(bankAccount.BankAccount.Balance, amount);
                        amount -= moneyToWithdraw;
                        bankAccount.BankAccount.Withdraw(moneyToWithdraw);
                    }

                    foreach (var creditCard in user.PaymentMethods.Where(pm => pm.CreditCardId != null))
                    {
                        decimal moneyToWithdraw = Math.Min(creditCard.CreditCard.MoneyOwned, amount);
                        amount -= moneyToWithdraw;
                        creditCard.CreditCard.Withdraw(moneyToWithdraw);

                        if (amount == 0)
                        {
                            return;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Insufficient funds!");
                }
            }
        }

        private string TryPrintUserDetails(int userId, User user)
        {
            StringBuilder sb = new StringBuilder();

            if (user != null)
            {
                sb.AppendLine($"User: {user.FirstName} {user.LastName}");
                sb.AppendLine("Bank Accounts:");

                foreach (var bankAccount in user.PaymentMethods.Where(pm => pm.BankAccountId != null))
                {
                    sb.AppendLine($"-- ID: {bankAccount.BankAccountId}");
                    sb.AppendLine($"--- Balance: {bankAccount.BankAccount.Balance}");
                    sb.AppendLine($"--- Bank: {bankAccount.BankAccount.BankName}");
                    sb.AppendLine($"--- Swift: {bankAccount.BankAccount.SwiftCode}");
                }

                sb.AppendLine("Credit Cards:");

                foreach (var creditCard in user.PaymentMethods.Where(pm => pm.CreditCardId != null))
                {
                    sb.AppendLine($"-- ID: {creditCard.CreditCard.CreditCardId}");
                    sb.AppendLine($"--- Limit: {creditCard.CreditCard.Limit}");
                    sb.AppendLine($"--- Money Owned: {creditCard.CreditCard.MoneyOwned}");
                    sb.AppendLine($"--- Limit Left: {creditCard.CreditCard.LimitLeft}");
                    sb.AppendLine($"--- Expiration Date: {creditCard.CreditCard.ExpirationDate.Year}/{creditCard.CreditCard.ExpirationDate.Month}");
                }

                return sb.ToString();
            }

            return $"User with id {userId} not found!";
        }
    }
}
