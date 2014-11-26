namespace _01.CreatingDbContextNorthwind
{
    using System;
    using System.Linq;

    //07.Try to open two different data contexts and perform concurrent changes on the same records. 
    //What will happen at SaveChanges()? How to deal with it?
    //{"Store update, insert, or delete statement affected an unexpected number of rows (0). Entities may have been modified or deleted since entities were loaded. Refresh ObjectStateManager entries."}
    class MakingConcurentChanges
    {
        static void Main()
        {
            var northwindFirstDb = new NorthwindEntities();
            var northwindSecondDb = new NorthwindEntities();
            DAO.InsertCustomer(northwindFirstDb,"NEWID", "Newly Added Company");

            using (northwindFirstDb)
            {
                var customerToUpdate = DAO.GetCustomerById(northwindFirstDb, "NEWID");
                customerToUpdate.CompanyName = "First Context Trying Concurent Changes";
                using (northwindSecondDb)
                {
                    var customerToDelete = DAO.GetCustomerById(northwindSecondDb, "NEWID");
                    northwindSecondDb.Customers.Remove(customerToDelete);
                    northwindSecondDb.SaveChanges();
                }
                northwindFirstDb.SaveChanges();
            }
        }
    }


}