namespace BankSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MortageAccount : Account, IDeposit
    {
        public MortageAccount(Customer customer, decimal balance, decimal interestRate)
            : base (customer, balance, interestRate)
        {

        }

        public void Deposit(decimal amount)
        {
            this.Balance += amount;
        }

        public override void CalculateInterest(int numberOfMonths)
        {
            if (numberOfMonths <= 6 && this.Customer == Customer.Individual)
            {
                Console.WriteLine("Mortgage accounts have no interest for the first 6 months for individuals.");
            }
            else if (numberOfMonths <= 12 && this.Customer == Customer.Company)
            {
                Console.WriteLine("Mortgage accounts have ½ interest for the first 12 months for companies");
                Console.WriteLine("The Interest amount for this account is: " + ((numberOfMonths * this.InterestRate)/2));
            }
            else if (this.Customer == Customer.Company)
            {
                Console.WriteLine("The Interest amount for this account is: " +
                    (((numberOfMonths - 12) * this.InterestRate) / 2));
            }
            else
                base.CalculateInterest(numberOfMonths - 6);
        }
    }
}
