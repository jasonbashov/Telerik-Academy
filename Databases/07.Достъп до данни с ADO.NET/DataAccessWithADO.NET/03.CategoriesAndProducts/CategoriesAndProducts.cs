namespace _03.CategoriesAndProducts
{
    using System;
    using System.Data.SqlClient;

    class CategoriesAndProducts
    {
        /*03.Write a program that retrieves from the Northwind database all product categories and
         * the names of the products in each category. Can you do this with a single SQL query (with table join)?
         */
        static void Main(string[] args)
        {
            SqlConnection dbCon = new SqlConnection(
                "Server=.\\SQLEXPRESS; " +
                "Database=Northwind; " +
                "Integrated Security=true");

            dbCon.Open();
            using (dbCon)
            {
                SqlCommand command = new SqlCommand("SELECT CategoryName, ProductName FROM Categories , " + 
                    "Products WHERE Categories.CategoryID = Products.CategoryID ", dbCon);
                SqlDataReader reader = command.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        string productName = (string)reader["ProductName"];
                        string categoryName = (string)reader["CategoryName"];
                        Console.WriteLine("Category name: {0}", productName);
                        Console.WriteLine("Category name: {0} ", categoryName);
                        Console.WriteLine("********************");
                    }
                }
            }
        }
    }
}
