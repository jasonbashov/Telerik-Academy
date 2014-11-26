namespace ExtractingArtists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml;

    //02.Write program that extracts all different artists which are found in the catalog.xml. 
    //For each author you should print the number of albums in the catalogue. Use the DOM parser and a hash-table.

    class ExtractingArtistsMain
    {
        static void Main(string[] args)
        {
            var artistsTable = new HashTable<string, int>();
            XmlDocument doc = new XmlDocument();
            doc.Load("../../catalouge.xml");
            Console.WriteLine("Loaded XML document:");
            Console.WriteLine(doc.OuterXml);
            Console.WriteLine();

            XmlNode rootNode = doc.DocumentElement;
            Console.WriteLine("Root node: {0}", rootNode.Name);

            Console.WriteLine();

            foreach (XmlNode parentNode in rootNode.ChildNodes)
            {
                var artistName = parentNode["artist"].InnerText;
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
