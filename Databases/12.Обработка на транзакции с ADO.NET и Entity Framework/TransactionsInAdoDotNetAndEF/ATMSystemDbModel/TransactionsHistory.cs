namespace ATMSystemDbModel
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class TransactionsHistory
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(10)]
        [MinLength(10)]
        public string CardNumber { get; set; }

        public DateTime TransactionDate { get; set; }

        public decimal Amount { get; set; }
    }
}
