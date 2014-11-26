namespace _01.CreatingDbContextNorthwind
{
    using System;
    using System.Linq;


    public class DAO
    {
        static void Main(string[] args)
        {
            
            NorthwindEntities northwindEntities = new NorthwindEntities();

            //02.Create a DAO class with static methods which provide functionality for inserting, 
            //modifying and deleting customers. Write a testing class.
            InsertCustomer(northwindEntities,"NEWID", "Newly Added Company");
            UpdateCustomer(northwindEntities, "NEWID", "UPDATED Added Company");
            DeleteCustomer(northwindEntities, "NEWID");

            //03.Write a method that finds all customers who have orders made in 1997 and shipped to Canada.
            FindAllCustomers(northwindEntities, 1997, "Canada");

            //04.Implement previous by using native SQL query and executing it through the DbContext.
            FindAllCustomerNativeSQL(northwindEntities, 1997, "Canada");

            //05.Write a method that finds all the sales by specified region and period (start / end dates).
            FindAllSales(northwindEntities, "Southern", new DateTime(1990, 11, 10), new DateTime(2000, 10, 11));

        }

        static void FindAllSales(NorthwindEntities northwindEntities, string region, DateTime startDate, DateTime endDate)
        {
            var salesByRegionAndYear = northwindEntities.Orders.Where(o => o.ShipRegion == region &&
                                                                  o.OrderDate > startDate &&
                                                                  o.OrderDate < endDate)
                                      .Select(o => new { ShipName = o.ShipName, OrderDate = o.OrderDate});
            foreach (var sale in salesByRegionAndYear)
            {
                Console.WriteLine("The sale is shiped by: {0}, on: {1}",sale.ShipName, sale.OrderDate);
            }

        }

        static void FindAllCustomers(NorthwindEntities northwindEntities, int searchedYear, string searchedCountry)
        {
            var customers = northwindEntities.Orders.Where(
                o => o.OrderDate.Value.Year == searchedYear && o.ShipCountry == searchedCountry);
            foreach (var cutomer in customers)
            {
                Console.WriteLine("Order made by: {0} with CustomerId: {1}", cutomer.Customer.ContactName, cutomer.CustomerID);
            }
        }

        static void FindAllCustomerNativeSQL(NorthwindEntities northwindEntities, int searchedYear, string searchedCountry)
        {
            string nativeSqlQuery =
                "SELECT c.ContactName " +
                "FROM Orders o " +
                "JOIN Customers c " +
                "ON o.CustomerID = c.CustomerID " +
                "WHERE o.OrderDate BETWEEN '{0}-01-01' AND '{0}-12-31' AND o.ShipCountry = '{1}' ";
            object[] parameters = { searchedYear, searchedCountry };
            var employees = northwindEntities.Database.SqlQuery<string>(string.Format(nativeSqlQuery, parameters));
            foreach (var emp in employees)
            {
                Console.WriteLine(emp);
            }
        }

        public static void InsertCustomer(NorthwindEntities northwindEntities, string customerId, string companyName)
        {
            if (!IsCustomerFound(northwindEntities, customerId))
            {
                Customer newCustomer = new Customer
                {
                    CustomerID = customerId,
                    CompanyName = companyName
                };
                northwindEntities.Customers.Add(newCustomer);
                northwindEntities.SaveChanges();
            }
            else
            {
                Console.WriteLine("There is already a customer with such ID");
            }
        }

        public static void UpdateCustomer(NorthwindEntities northwindEntities, string customerId, string newName)
        {
            var customerToUpdate = GetCustomerById(northwindEntities, customerId);
            customerToUpdate.CompanyName = newName;
            northwindEntities.SaveChanges();
        }

        public static void DeleteCustomer(NorthwindEntities northwindEntities, string customerId)
        {
            if (IsCustomerFound(northwindEntities, customerId))
            {
                var customerToDelete = GetCustomerById(northwindEntities, customerId);
                northwindEntities.Customers.Remove(customerToDelete);
                northwindEntities.SaveChanges();
                Console.WriteLine("Customer deleted successfuly");
            }
            else
            {
                Console.WriteLine("There is no such customer");
            }
        }

        public static Customer GetCustomerById(NorthwindEntities northwindEntities, string customerId)
        {
            Customer customer = northwindEntities.Customers.FirstOrDefault(c => c.CustomerID == customerId);
            return customer;
        }

        private static bool IsCustomerFound(NorthwindEntities northwindEntities, string customerId)
        {
            return northwindEntities.Customers.Any(c => c.CustomerID == customerId);
        }
    }
}
