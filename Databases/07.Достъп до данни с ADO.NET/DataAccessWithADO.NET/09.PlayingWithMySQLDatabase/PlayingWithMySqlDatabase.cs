namespace _09.PlayingWithMySQLDatabase
{
    using MySql.Data.MySqlClient;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class PlayingWithMySqlDatabase
    {
        static void Main(string[] args)
        {
            MySqlConnection dbConnection = new MySqlConnection("Server=localhost; Port=3306; Database=booksdb; Uid=root; Pwd=; pooling=true");

            dbConnection.Open();
            using (dbConnection)
            {
                //Listing all books
                MySqlCommand command = new MySqlCommand("SELECT * FROM Books", dbConnection);
                MySqlDataReader reader = command.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        string name = (string)reader["Title"];
                        Console.WriteLine("Book name: {0}", name);
                        Console.WriteLine("********************");
                    }
                }

                //Searching for a given book
                //Was going to do it with user input but this way is easier :)
                string bookName = "'A Game of Thrones'";

                command = new MySqlCommand("SELECT * FROM Books, Authors WHERE Title = " + bookName + " AND Books.AuthorId = Authors.AuthorId", dbConnection);
                reader = command.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        string name = (string)reader["Title"];
                        string author = (string)reader["AuthorName"];
                        Console.WriteLine("The searched book name is: {0}, by: {1}", name, author);
                        Console.WriteLine("********************");
                    }
                }

                //Adding new book
                command = new MySqlCommand("INSERT INTO Books (Title, PublishDate, ISBN, AuthorId) VALUES (@title, @publishDate, @ISBN, @AuthorId)", dbConnection);
               
                command.Parameters.AddWithValue("@title", "Harry Potter And The Prisoner of Azkaban");
                command.Parameters.AddWithValue("@publishDate", "2001.01.01");
                command.Parameters.AddWithValue("@ISBN", "112345699");
                command.Parameters.AddWithValue("@authorId", "4");
                command.ExecuteNonQuery();
                Console.WriteLine("New book inserted successfuly!");
            }
        }
    }
}
