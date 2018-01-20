namespace P01_BillsPaymentSystem.Data.Models
{
    using System;

    public class CreditCard
    {
        public CreditCard(decimal limit, decimal moneyOwned, string expirationDate)
        {
            this.Limit = limit;
            this.MoneyOwned = moneyOwned;
            this.ExpirationDate = DateTime.Parse(expirationDate);
        }

        public CreditCard()
        {
            
        }

        public int CreditCardId { get; set; }

        public decimal Limit { get; private set; }

        public decimal MoneyOwned { get; private set; }

        public decimal LimitLeft => this.Limit - this.MoneyOwned;

        public DateTime ExpirationDate { get; set; }

        public int PaymentMethodId { get; set; }
        public PaymentMethod PaymentMethod { get; set; }

        public void Withdraw(decimal amount)
        {
            this.MoneyOwned -= amount;
        }

        public void Deposit(decimal amount)
        {
            this.MoneyOwned += amount;
        }
    }
}
