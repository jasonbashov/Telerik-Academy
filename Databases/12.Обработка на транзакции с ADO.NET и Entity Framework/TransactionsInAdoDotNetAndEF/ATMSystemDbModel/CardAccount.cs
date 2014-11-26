namespace ATMSystemDbModel
{
    using System.ComponentModel.DataAnnotations;

    public class CardAccount
    {
        public CardAccount()
        {
        }

        [Key]
        public int Id { get; set; }

        [MaxLength(10)]
        [MinLength(10)]
        public string CardNumber { get; set; }

        [MaxLength(4)]
        [MinLength(4)]
        public string Pin { get; set; }

        public decimal CardCash { get; set; }

        public int CardHolderId { get; set; }

        public virtual CardHolder CardHolder { get; set; }

    }
}
