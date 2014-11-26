namespace ATMSystemDbModel
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class CardHolder
    {
        private ICollection<CardAccount> cardAccounts;

        public CardHolder()
        {
            this.cardAccounts = new HashSet<CardAccount>();
        }

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<CardAccount> CardAccounts
        {
            get
            {
                return this.cardAccounts;
            }
            private set
            {
                this.cardAccounts = value;
            }
        }
    }
}
