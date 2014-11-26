namespace _04.AddingNewProduct
{
    using System;
    using System.Data.SqlClient;

    // 04.Write a method that adds a new product in the products table in the Northwind database.
    // Use a parameterized SQL command.
    class AddingNewProduct
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
                SqlCommand cmd = new SqlCommand("INSERT INTO Products " +
                    "(ProductName, Discontinued) VALUES " +
                    "(@name, @disc)", dbCon);
                cmd.Parameters.AddWithValue("@name", "Newly Added Product");
                cmd.Parameters.AddWithValue("@disc", false);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
