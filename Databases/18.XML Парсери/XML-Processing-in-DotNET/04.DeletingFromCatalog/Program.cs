namespace DeletingFromCatalog
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml;


    //04.Using the DOM parser write a program to delete from catalog.xml all albums having price > 20.

    class Program
    {
        static void Main()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("../../catalogue.xml");
            string xPathQuery = "/albums/album";

            XmlNodeList albumsList = xmlDoc.SelectNodes(xPathQuery);
            foreach (XmlNode albumNode in albumsList)
            {
                string albumPrice = albumNode.SelectSingleNode("price").InnerText;
                if (decimal.Parse(albumPrice) > 20)
                {
                    albumNode.ParentNode.RemoveChild(albumNode);
                }
            }

            xmlDoc.Save("../../deletedCatalogue.xml");
        }
    }
}
