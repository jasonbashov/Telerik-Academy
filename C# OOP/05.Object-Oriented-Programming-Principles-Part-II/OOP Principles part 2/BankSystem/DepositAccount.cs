using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    public class DepositAccount : Account, IDeposit, IWithdraw
    {
        public DepositAccount(Customer customer, decimal balance, decimal interestRate)
            : base (customer, balance, interestRate)
        {

        }
        public void Deposit(decimal amount)
        {
            this.Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            this.Balance -= amount;
        }

        public override void CalculateInterest(int numberOfMonths)
        {
            if (this.Balance > 0 && this.Balance <= 1000)
            {
                Console.WriteLine("Deposit accounts have no interest if their balance is positive and less than 1000.");
            }
            else
                base.CalculateInterest(numberOfMonths);
        }
    }
}
