
namespace _02.CategoriesNamesAndDescription
{
    using System;
    using System.Data.SqlClient;

    /*
     * 02.Write a program that retrieves the name and description of all categories in the Northwind DB.
    */
    class CategoriesNamesAndDescription
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
                SqlCommand command = new SqlCommand("SELECT CategoryName, Description FROM Categories", dbCon);
                SqlDataReader reader = command.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        string name = (string)reader["CategoryName"];
                        string description = (string)reader["Description"];
                        Console.WriteLine("Category name: {0}", name);
                        Console.WriteLine("Category description: {0} ", description);
                        Console.WriteLine("********************");
                    }
                }
            }
        }
    }
}
