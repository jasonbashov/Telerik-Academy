namespace ExtractingSongTitles
{
    using System;
    using System.Xml;

    ///05.Write a program, which using XmlReader extracts all song titles from catalog.xml.
    public class Program
    {
        public  static void Main()
        {
            Console.WriteLine("Song titles in the catalog:");
            using (XmlReader reader = XmlReader.Create("../../catalog.xml"))
            {
                while (reader.Read())
                {
                    if ((reader.NodeType == XmlNodeType.Element) &&
                        (reader.Name == "title"))
                    {
                        Console.WriteLine(reader.ReadElementString());
                    }
                }
            }
        }
    }
}
