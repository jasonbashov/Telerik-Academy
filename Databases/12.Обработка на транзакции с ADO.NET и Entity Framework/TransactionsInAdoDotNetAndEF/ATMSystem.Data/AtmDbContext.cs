namespace ATMSystem.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    using ATMSystemDbModel;
    using ATMSystem.Data.Migrations;

    public class AtmDbContext : DbContext
    {
        public AtmDbContext()
            : base("AtmDbContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<AtmDbContext, Configuration>());
        }

        public IDbSet<CardAccount> CardAccounts { get; set; }

        public IDbSet<CardHolder> CardHolders { get; set; }

        public IDbSet<TransactionsHistory> TransactionsHistories { get; set; }
    }
}