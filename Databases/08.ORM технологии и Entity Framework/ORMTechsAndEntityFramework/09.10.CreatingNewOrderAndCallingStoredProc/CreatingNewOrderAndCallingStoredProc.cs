namespace _01.CreatingDbContextNorthwind
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using CreatingDbContextNorthwind;
    using System.Transactions;
    using System.Data.SqlClient;
    using System.Data;

    //09.Create a method that places a new order in the Northwind database. 
    //The order should contain several order items. Use transaction to ensure the data consistency.
    //10.Create a stored procedures in the Northwind database for finding the total incomes for given supplier 
    //name and period (start date, end date). Implement a C# method that calls the stored procedure 
    //and returns the retuned record set.

    class CreatingNewOrderAndCallingStoredProc
    {
        static void Main(string[] args)
        {
            var northwindDbContext = new NorthwindEntities();
            CreateNewOrder(northwindDbContext);
            ExecuteStoredProc("Exotic Liquids", new DateTime(1990, 01, 01), new DateTime(2000, 01, 01));
        }

        //Task 09
        static void CreateNewOrder(NorthwindEntities northwindDbContext)
        {
            //EF ussualy uses transactions on its owns so there is no need of this extra transaction scope but whatever
            using (TransactionScope scope = new TransactionScope())
            {
                using (northwindDbContext)
                {
                    var newORder = new Order
                    {
                        OrderDate = new DateTime(2014, 08, 30),
                        RequiredDate = new DateTime(2014, 09, 15),
                        ShippedDate = new DateTime(2014, 09, 08),
                        Freight = 50,
                        ShipName = "Red Army",
                        ShipAddress = "White house 1",
                        ShipCity = "Washington DC",
                        ShipCountry = "USA"
                    };
                    northwindDbContext.Orders.Add(newORder);

                    northwindDbContext.SaveChanges();
                    Console.WriteLine("Order added successfuly");

                    scope.Complete();
                }
            }
        }

        //Task 10
        static void ExecuteStoredProc(string supplierName, DateTime starDate, DateTime endDate)
        {
            SqlConnection dbConnection = new SqlConnection(
                "Server=PC-PC\\SQLEXPRESS; " +
                "Database=Northwind; " +
                "Integrated Security=true");

            using (dbConnection)
            {
                dbConnection.Open();

                // 1.  create a command object identifying the stored procedure
                SqlCommand cmd = new SqlCommand("uspFindTotalIncome", dbConnection);

                // 2. set the command object so it knows to execute a stored procedure
                cmd.CommandType = CommandType.StoredProcedure;

                // 3. add parameter to command, which will be passed to the stored procedure
                cmd.Parameters.Add(new SqlParameter("@SupplierCompanyName", supplierName));
                cmd.Parameters.Add(new SqlParameter("@StartDate", starDate));
                cmd.Parameters.Add(new SqlParameter("@EndDate", endDate));

                // execute the command
                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    // iterate through results, printing each to console
                    while (rdr.Read())
                    {
                        Console.WriteLine("Total: {0}", rdr["Total"]);
                    }
                }
            }
        }
    }
}
