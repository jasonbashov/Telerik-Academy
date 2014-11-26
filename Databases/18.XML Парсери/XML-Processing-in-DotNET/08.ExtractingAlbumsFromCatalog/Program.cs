namespace ExtractingAlbumsFromCatalog
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml;

    //08.Write a program, which (using XmlReader and XmlWriter) reads the file catalog.xml and creates the 
    //file album.xml, in which stores in appropriate way the names of all albums and their authors.

    class Program
    {
        static void Main()
        {
            string fileName = "../../albums.xml";
            Encoding encoding = Encoding.GetEncoding("windows-1251");
            var currentAlbumInfo = new List<string>();

            using (XmlReader reader = XmlReader.Create("../../catalog.xml"))
            {
                using (XmlTextWriter writer = new XmlTextWriter(fileName, encoding))
                {
                    writer.Formatting = Formatting.Indented;
                    writer.IndentChar = '\t';
                    writer.Indentation = 1;

                    writer.WriteStartDocument();
                    writer.WriteStartElement("albums");
                    while (reader.Read())
                    {
                        if ((reader.NodeType == XmlNodeType.Element) &&
                            (reader.Name == "name"))
                        {
                            currentAlbumInfo.Add(reader.ReadElementString());
                        }
                        else if ((reader.NodeType == XmlNodeType.Element) &&
                            (reader.Name == "artist"))
                        {
                            currentAlbumInfo.Add(reader.ReadElementString());
                        }

                        if (currentAlbumInfo.Count == 2)
                        {
                            writer.WriteStartElement("album");
                            writer.WriteElementString("name", currentAlbumInfo[0]);
                            writer.WriteElementString("artist", currentAlbumInfo[1]);
                            writer.WriteEndElement();
                            currentAlbumInfo.Clear();
                        }
                    }
                    writer.WriteEndElement();
                    writer.WriteEndDocument();
                }
            }
        }
    }
}
