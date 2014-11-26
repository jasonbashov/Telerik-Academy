namespace _05.RetrievingImages
{
    using System;
    using System.Data.SqlClient;
    using System.IO;

    //05.Write a program that retrieves the images for all categories in the Northwind database and 
    //stores them as JPG files in the file system.
    class RetrievingImages
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
                SqlCommand cmd = new SqlCommand("SELECT Picture, CategoryName FROM Categories", dbCon);

                SqlDataReader reader = cmd.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        byte[] fileData = (byte[])reader["Picture"];
                        string fileName = reader["CategoryName"].ToString().Replace('/', '_') + ".jpg";

                        WriteBinaryFile(@"..\..\" + fileName, fileData);

                        /* tried to save them in pdf but the 78 char header broke it
                        
                        using (System.IO.FileStream fs = new System.IO.FileStream(
                            sPathToSaveFileTo,
                            System.IO.FileMode.Create,
                            System.IO.FileAccess.ReadWrite))
                        {
                            // use a binary writer to write the bytes to disk
                            string sPathToSaveFileTo = @"C:\SavedFile.pdf";
                            using (System.IO.BinaryWriter bw = new System.IO.BinaryWriter(fs))
                            {
                                bw.Write(fileData);
                                bw.Close();
                            }
                        }*/
                    }
                }

            }
        }

        private static void WriteBinaryFile(string fileName, byte[] fileContents)
        {
            FileStream stream = File.OpenWrite(fileName);
            using (stream)
            {
                stream.Write(fileContents, 78, fileContents.Length - 78);
            }
        }
    }
}
