namespace ExtractingPrices
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml;

    //11.Write a program, which extract from the file catalog.xml the prices for all albums, published 5 years ago or earlier. 
    //Use XPath query.
    class Program
    {
        static void Main()
        {
            var pricesDictionary = new Dictionary<string,decimal>();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("../../catalog.xml");
            string xPathQuery = "/albums/album";

            XmlNodeList albumsList = xmlDoc.SelectNodes(xPathQuery);
            foreach (XmlNode albumsNode in albumsList)
            {
                string albumYear = albumsNode.SelectSingleNode("year").InnerText;
                if (int.Parse(albumYear) >= (DateTime.Now.Year - 5))
                {
                    var priceString = albumsNode.SelectSingleNode("price").InnerText;
                    var albumName = albumsNode.SelectSingleNode("name").InnerText;
                    pricesDictionary.Add(albumName,decimal.Parse(priceString));
                }

            }

            Console.WriteLine("The prices of the albums pubished after: {0}", (DateTime.Now.Year - 5));
            foreach (var price in pricesDictionary)
            {
                Console.WriteLine("The album: " + price.Key + " costs: " + price.Value);
            }
        }
    }
}
