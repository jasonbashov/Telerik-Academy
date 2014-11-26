namespace _07.InsertingIntoExcel
{
    using System;
    using System.Data.OleDb;
    //Implement appending new rows to the Excel file.

    class InsertingIntoExcel
    {
        static void Main(string[] args)
        {
            OleDbConnection excelConnection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;" +
           @"Data Source=..\\..\\ExcelDatabase.xlsx;Extended Properties=""Excel 12.0 XML;HDR=Yes""");

            excelConnection.Open();

            using (excelConnection)
            {
                OleDbCommand myCommand = new OleDbCommand("INSERT INTO [Sheet1$] (Name, Score) VALUES (@name, @score)", excelConnection);

                myCommand.Parameters.AddWithValue("@name", "New Gosho");
                myCommand.Parameters.AddWithValue("@score", 19);
                myCommand.ExecuteNonQuery();
            }
        }
    }
}
