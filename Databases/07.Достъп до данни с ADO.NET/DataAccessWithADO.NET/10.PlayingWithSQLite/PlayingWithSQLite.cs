using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.PlayingWithSQLite
{
    class PlayingWithSQLite
    {
        static void Main(string[] args)
        {
            //Change the connection string 
            SQLiteConnection dbConnection = new SQLiteConnection(@"Data Source=D:\Telerik\Database\Homework\07.Достъп до данни с ADO.NET\DataAccessWithADO.NET\10.PlayingWithSQLite\bookLib.sqlite; Version=3;");

            dbConnection.Open();
            using (dbConnection)
            {
                //Listing all books
                SQLiteCommand command = new SQLiteCommand("SELECT * FROM Books", dbConnection);
                SQLiteDataReader reader = command.ExecuteReader();
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

                command = new SQLiteCommand("SELECT * FROM Books, Authors WHERE Title = " + bookName + " AND Books.AuthorId = Authors.AuthorId", dbConnection);
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
                command = new SQLiteCommand("INSERT INTO Books (Title, PublishDate, ISBN, AuthorId) VALUES (@title, @publishDate, @ISBN, @AuthorId)", dbConnection);

                command.Parameters.AddWithValue("@title", "A Feast of Crows");
                command.Parameters.AddWithValue("@publishDate", "2001.01.01");
                command.Parameters.AddWithValue("@ISBN", "112375999");
                command.Parameters.AddWithValue("@authorId", "2");
                command.ExecuteNonQuery();
                Console.WriteLine("New book inserted successfuly!");
            }
        }
    }
}
