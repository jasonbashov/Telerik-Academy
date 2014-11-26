namespace _11.CreatingNewDatabase
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Transactions;

    //11.Create a database holding users and groups. Create a transactional EF based method that creates an 
    //user and puts it in a group "Admins". In case the group "Admins" do not exist, create the group in
    //the same transaction. If some of the operations fail (e.g. the username already exist), cancel the entire transaction.

    class CreatingNewDatabase
    {
        static void Main(string[] args)
        {
            CreateUser("NewUser", "Admin");
        }

        private static void CreateUser(string username, string group)
        {
            SimpleUsersEntitiesEntities dbContext = new SimpleUsersEntitiesEntities();

            try
            {
                using (TransactionScope dbScope = new TransactionScope())
                {
                    User user = new User
                    {
                        UserName = username
                    };

                    if (IsUserFound(dbContext, username))
                    {
                        Console.WriteLine("Such user already exists");
                        dbScope.Dispose();
                    }
                    else
                    {


                        Group admins = dbContext.Groups.FirstOrDefault(g => g.GroupName == group);

                        if (admins == null)
                        {
                            admins = new Group { GroupName = group, Users = new HashSet<User>() };
                            dbContext.Groups.Add(admins);
                        }
                        else
                        {
                            dbContext.Groups.Attach(admins);
                        }

                        admins.Users.Add(user);

                        dbContext.SaveChanges();
                        dbScope.Complete();
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error: {0}", ex.Message);
            }
        }
 
        private static bool IsUserFound(SimpleUsersEntitiesEntities dbContext, string userName)
        {
            return dbContext.Users.Any(u => u.UserName == userName);
        }
    }
}
