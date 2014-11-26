namespace ATMSystem.ConsoleClient
{
    using System;
    using System.Data.Entity.Core;
    using System.Linq;
    using System.Transactions;

    using ATMSystem.Data;
    using ATMSystemDbModel;

    class Program
    {
        static void Main()
        {
            var db = new AtmDbContext();
            db.Database.Initialize(true);
            Console.WriteLine("Connecting to ATM...");

            SeedDatabase();

            ExecuteTransaction();
        }

        static void ExecuteTransaction()
        {
            string cardNumber = "0000000001";
            string cardPin = "0001";

            while (true)
            {
                try
                {
                    WithdrawMoney(cardNumber, cardPin);
                    Console.WriteLine("Transaction completed!");
                }
                catch (EntityException e)
                {
                    Console.WriteLine("Operation failed...");
                    Console.WriteLine(e.InnerException.Message);
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (InvalidOperationException e)
                {
                    Console.WriteLine(e.Message);
                }

                Console.WriteLine("Would you like to make another transaction (Y/N)?");
                if (Console.ReadKey(true).Key == ConsoleKey.N)
                {
                    break;
                }
            }

            Console.WriteLine("Thank you for using our corrupted bank!");
        }

        static void WithdrawMoney(string cardNumber, string cardPin)
        {
            if (cardNumber == null)
            {
                throw new ArgumentNullException("Card number cannot be null!");
            }

            if (cardPin == null)
            {
                throw new ArgumentNullException("Card PIN cannot be null!");
            }

            if (cardNumber.Length != 10)
            {
                throw new ArgumentException("Invalid card number! Card number must consist of 10 digits!");
            }

            if (cardPin.Length != 4)
            {
                throw new ArgumentException("Invalid card PIN! Card PIN must consist of 4 digits!");
            }

            var options = new TransactionOptions();
            options.IsolationLevel = IsolationLevel.RepeatableRead;
            using (var scope = new TransactionScope(TransactionScopeOption.Required, options))
            {
                using (var db = new AtmDbContext())
                {
                    var acc = db.CardAccounts.FirstOrDefault(a => a.CardNumber == cardNumber && a.Pin == cardPin);

                    if (acc == null)
                    {
                        scope.Dispose();
                        throw new InvalidOperationException("Wrong CardNumber or PIN!");
                    }

                    PrintBalance(acc.CardCash);
                    decimal amount = GetClientInput();

                    if (amount < 0)
                    {
                        scope.Dispose();
                        throw new InvalidOperationException("You cannot withdraw negative amount!");
                    }

                    if (acc.CardCash < amount)
                    {
                        scope.Dispose();
                        throw new InvalidOperationException("Insufficient balance!");
                    }

                    acc.CardCash -= amount;
                    db.SaveChanges();

                    SaveTransactionHistory(cardNumber, amount, db);

                    PrintBalance(acc.CardCash);
                }

                scope.Complete();
            }
        }

        private static void SaveTransactionHistory(string cardNumber, decimal amount, AtmDbContext db)
        {
            var options = new TransactionOptions
            {
                IsolationLevel = IsolationLevel.RepeatableRead,
                Timeout = new TimeSpan(0, 0, 0, 10)
            };

            using (var scope = new TransactionScope(TransactionScopeOption.Required, options))
            {
                db.TransactionsHistories.Add(new TransactionsHistory
                {
                    CardNumber = cardNumber,
                    TransactionDate = DateTime.Now,
                    Amount = amount
                });

                db.SaveChanges();

                scope.Complete();
            }
        }

        private static void PrintBalance(decimal cardCash)
        {
            Console.WriteLine("Your current account balance: {0:C}", cardCash);
        }

        private static decimal GetClientInput()
        {
            Console.Write("Please enter withdraw amount: ");
            decimal amount = decimal.Parse(Console.ReadLine());
            return amount;
        }

        private static void SeedDatabase()
        {
            using (var db = new AtmDbContext())
            {
                db.Database.ExecuteSqlCommand("DELETE FROM CardAccounts");
                db.Database.ExecuteSqlCommand("DELETE FROM CardHolders");
                db.CardAccounts.Add(new CardAccount()
                {
                    CardNumber = "0000000001",
                    Pin = "0001",
                    CardCash = 1000.00m,
                    CardHolder = new CardHolder() { Name = "Gosho" }
                });
                SaveChanges(db);
            }
        }

        private static void SaveChanges(AtmDbContext db)
        {
            db.SaveChanges();
        }
    }
}