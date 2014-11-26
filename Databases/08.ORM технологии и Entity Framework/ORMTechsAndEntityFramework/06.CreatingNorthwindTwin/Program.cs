using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
//06.Create a database called NorthwindTwin with the same structure as Northwind using the features from DbContext.
//Find for the API for schema generation in MSDN or in Google.
namespace _01.CreatingDbContextNorthwind
{
    class Program
    {
        static void Main(string[] args)
        {
            IObjectContextAdapter northwindDb = new NorthwindEntities();
            var cloneNorthwind = northwindDb.ObjectContext.CreateDatabaseScript();

            string createNorthwindCloneDBSql = "CREATE DATABASE NorthwindTwin ON PRIMARY " +
                "(NAME = NorthwindTwin, " +
                "FILENAME = 'D:\\NorthwindTwin.mdf', " +
                "SIZE = 5MB, MAXSIZE = 10MB, FILEGROWTH = 10%) " +
                "LOG ON (NAME = NorthwindTwinLog, " +
                "FILENAME = 'D:\\NorthwindTwin.ldf', " +
                "SIZE = 1MB, " +
                "MAXSIZE = 5MB, " +
                "FILEGROWTH = 10%)";

            SqlConnection dbConnectionForCreatingDB = new SqlConnection(
                "Server=PC-PC\\SQLEXPRESS; " +
                "Database=master; " +
                "Integrated Security=true");

            dbConnectionForCreatingDB.Open();

            using (dbConnectionForCreatingDB)
            {
                SqlCommand createDbTwin = new SqlCommand(createNorthwindCloneDBSql, dbConnectionForCreatingDB);
                createDbTwin.ExecuteNonQuery();
            }

            SqlConnection dbConnectionForCloning = new SqlConnection(
            "Server=PC-PC\\SQLEXPRESS; " +
            "Database=NorthwindTwin; " +
            "Integrated Security=true");

            dbConnectionForCloning.Open();

            using (dbConnectionForCloning)
            {
                SqlCommand cloneDB = new SqlCommand(cloneNorthwind, dbConnectionForCloning);
                cloneDB.ExecuteNonQuery();
            }
        }
    }

}