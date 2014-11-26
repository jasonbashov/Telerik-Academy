namespace DataAccessWithADO.NET
{
    using System;
    using System.Data.SqlClient;

    /*01.Write a program that retrieves from the Northwind sample database in MS SQL Server the number of  
     * rows in the Categories table.
     */
    class NumberOfRowsInCategories
    {
        static void Main(string[] args)
        {
            SqlConnection dbCon = new SqlConnection(
                "Server=.\\SQLEXPRESS; " +
                "Database=Northwind; " +
                "Integrated Security=true");

            dbCon.Open();
            using (dbCon)
            {
                SqlCommand command = new SqlCommand(
                  "SELECT COUNT(*) FROM Categories", dbCon);
                int categoriesCount = (int)command.ExecuteScalar();
                Console.WriteLine("Categories row count: {0} ", categoriesCount);
            }
        }
    }
}
