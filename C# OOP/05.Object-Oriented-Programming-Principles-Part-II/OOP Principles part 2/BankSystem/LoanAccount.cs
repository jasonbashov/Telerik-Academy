namespace BankSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class LoanAccount : Account, IDeposit
    {
        public LoanAccount(Customer customer, decimal balance, decimal interestRate)
            : base (customer, balance, interestRate)
        {

        }

        public void Deposit(decimal amount)
        {
            this.Balance += amount;
        }

        public override void CalculateInterest(int numberOfMonths)
        {
            if (numberOfMonths <=3  && this.Customer == Customer.Individual)
            {
                Console.WriteLine("Loan accounts have no interest for the first 3 months if are held by individuals");
            }
            else if (numberOfMonths <= 2 && this.Customer == Customer.Company)
            {
                Console.WriteLine("Loan accounts have no interest for the first 2 months if are held by a company");
            }
            else if (this.Customer == Customer.Individual)
                base.CalculateInterest(numberOfMonths - 3);
            else
                base.CalculateInterest(numberOfMonths - 2);
        }
    }
}
