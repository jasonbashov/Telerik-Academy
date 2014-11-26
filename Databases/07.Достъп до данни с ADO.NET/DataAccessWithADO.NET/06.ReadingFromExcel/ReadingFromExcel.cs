namespace _06.ReadingFromExcel
{
    using System;
    using System.Data.OleDb;

    //Create an Excel file with 2 columns: name and score
    //Write a program that reads your MS Excel file through the OLE DB data provider
    //and displays the name and score row by row.

    class ReadingFromExcel
    {
        static void Main(string[] args)
        {
            string pathToFile = "..\\..\\ExcelDatabase.xlsx";
            string provider = "Microsoft.ACE.OLEDB.12.0";
            string properties = "Excel 12.0;HDR=Yes;IMEX=2";
            string connectionString = String.Format("Provider = {0}; Data Source={1}; Extended Properties = \"{2}\"", provider, pathToFile, properties);
            OleDbConnection excelConnection = new OleDbConnection(connectionString);

            excelConnection.Open();

            OleDbCommand myCommand = new OleDbCommand("select * from [Sheet1$]", excelConnection);

            using (excelConnection)
            {
                OleDbDataReader reader = myCommand.ExecuteReader();

                while (reader.Read())
                {
                    string name = (string)reader["Name"];
                    double score = (double)reader["Score"];
                    Console.WriteLine("Person name: {0} - score: {1}", name, score);
                }
            }
        }
    }
}
