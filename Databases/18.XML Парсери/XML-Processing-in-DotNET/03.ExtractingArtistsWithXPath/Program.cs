namespace ExtractingArtistsWithXPath
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml;

    using ExtractingArtists;

    //03.Implement the previous using XPath.

    class Program
    {
        static void Main()
        {
            var artistsTable = new HashTable<string, int>();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("../../catalogue.xml");
            string xPathQuery = "/albums/album";

            XmlNodeList artistsList = xmlDoc.SelectNodes(xPathQuery);
            foreach (XmlNode artistNode in artistsList)
            {
                string artistName = artistNode.SelectSingleNode("artist").InnerText;
                if (artistsTable.ContainsKey(artistName))
                {
                    artistsTable[artistName]++;
                }
                else
                {
                    artistsTable.Add(artistName, 1);
                }
            }

            foreach (var artist in artistsTable)
            {
                Console.WriteLine("{0} has: {1} albums", artist.Key, artist.Value);
            }
        }
    }
}
