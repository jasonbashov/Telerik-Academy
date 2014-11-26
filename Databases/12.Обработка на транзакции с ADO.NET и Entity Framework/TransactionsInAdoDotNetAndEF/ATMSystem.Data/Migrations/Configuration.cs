namespace ATMSystem.Data.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<AtmDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "ATMSystem.Data.AtmDbContext";
        }

        protected override void Seed(AtmDbContext context)
        {
        }
    }
}
