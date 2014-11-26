namespace _08.SearchingProductsByString
{
    using System;
    using System.Data.SqlClient;

    //08.Write a program that reads a string from the console and finds all products that contain this string.
    //Ensure you handle correctly characters like ', %, ", \ and _.
    class SearchingProductsByString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string to search for containment");
            string containingPattern = Console.ReadLine();

            SqlConnection dbCon = new SqlConnection(
                "Server=.\\SQLEXPRESS; " +
                "Database=Northwind; " +
                "Integrated Security=true");

            dbCon.Open();
            using (dbCon)
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Products p WHERE p.ProductName LIKE '%" + containingPattern + "%'", dbCon);
                SqlDataReader reader = command.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        string productName = (string)reader["ProductName"];
                        Console.WriteLine("Category name: {0}", productName);
                        Console.WriteLine("********************");
                    }
                }
            }
        }
    }
}
