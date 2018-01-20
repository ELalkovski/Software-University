namespace P01_BillsPaymentSystem.Data
{
    using System;
    using P01_BillsPaymentSystem.Data.Models;

    public class DatabaseInitializer
    {
        public void ResetDatabase(BillsPaymentSystemContext db)
        {
            db.Database.EnsureDeleted();
            db.Database.EnsureCreated();
            this.Seed(db);
        }

        public void Seed(BillsPaymentSystemContext db)
        {
            User[] users =
            {
                new User
                {
                    FirstName = "Dragan",
                    LastName = "Manolov",
                    Email = "test@abv.bg",
                    Password = "123456"
                },

                new User
                {
                    FirstName = "Ivan",
                    LastName = "Ivanov",
                    Email = "vancho@abv.bg",
                    Password = "dfsdfjskdl"
                },

                new User
                {
                    FirstName = "Pesho",
                    LastName = "Peshev",
                    Email = "petraki@abv.bg",
                    Password = "arebe"
                },

                new User
                {
                    FirstName = "Kristian",
                    LastName = "Stefanov",
                    Email = "bulk@abv.bg",
                    Password = "2433223"
                },

                new User
                {
                    FirstName = "Vasil",
                    LastName = "Todorov",
                    Email = "tosheto@abv.bg",
                    Password = "dfsf2314"
                },
            };
            db.Users.AddRange(users);

            BankAccount[] bankAccounts =
            {
                new BankAccount(15000.00m, "DSK Bank", "ASDAS21431DFSF"),
                new BankAccount(4000.00m, "FirstInvestment Bank", "1231SSFSAS1243"),
                new BankAccount(8000.00m, "DSK Bank", "21431SSFSAFD1T"),
                new BankAccount(22000.00m, "Piraeos Bank", "DFS12414SFFSA"),
                new BankAccount(10000.00m, "Postbank", "432SDADSA143F")
            };
            db.BankAccounts.AddRange(bankAccounts);

            CreditCard[] creditCards =
            {
                new CreditCard(15000.00m, 15000.00m, "01.01.2019"),
                new CreditCard(5000.00m, 2000.00m, "01.01.2019"),
                new CreditCard(9000.00m, 12000.00m, "01.01.2019"),
                new CreditCard(3000.00m, 1000.00m, "01.01.2019"),
                new CreditCard(1000.00m, 4500.00m, "01.01.2019")
            };
            db.CreditCards.AddRange(creditCards);

            PaymentMethod[] paymentMethods =
            {
                new PaymentMethod
                {
                    Type = PaymentMethodType.BankAccount,
                    UserId = 5,
                    User = users[4],
                    BankAccountId = 1,
                    BankAccount = bankAccounts[0]
                },

                new PaymentMethod
                {
                    Type = PaymentMethodType.CreditCard,
                    UserId = 5,
                    User = users[4],
                    CreditCardId = 3,
                    CreditCard = creditCards[2]
                },

                new PaymentMethod
                {
                    Type = PaymentMethodType.CreditCard,
                    UserId = 2,
                    User = users[1],
                    CreditCardId = 5,
                    CreditCard = creditCards[4]
                },

                new PaymentMethod
                {
                    Type = PaymentMethodType.CreditCard,
                    UserId = 1,
                    User = users[0],
                    CreditCardId = 4,
                    CreditCard = creditCards[3]
                },

                new PaymentMethod
                {
                    Type = PaymentMethodType.BankAccount,
                    UserId = 4,
                    User = users[3],
                    BankAccountId = 3,
                    BankAccount = bankAccounts[2]
                },

                new PaymentMethod
                {
                    Type = PaymentMethodType.BankAccount,
                    UserId = 1,
                    User = users[0],
                    BankAccountId = 4,
                    BankAccount = bankAccounts[3]
                },

                new PaymentMethod
                {
                    Type = PaymentMethodType.BankAccount,
                    UserId = 3,
                    User = users[2],
                    BankAccountId = 2,
                    BankAccount = bankAccounts[1]
                },

                new PaymentMethod
                {
                    Type = PaymentMethodType.CreditCard,
                    UserId = 3,
                    User = users[2],
                    CreditCardId = 1,
                    BankAccount = bankAccounts[0]
                },
            };
            db.PaymentMethods.AddRange(paymentMethods);

            db.SaveChanges();
        }
    }
}
