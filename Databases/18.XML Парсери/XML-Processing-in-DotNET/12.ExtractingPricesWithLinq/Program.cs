namespace ExtractingPricesWithLinq
{
    using System;
    using System.Linq;
    using System.Xml.Linq;

    //12.Rewrite the previous using LINQ query.
    class Program
    {
        static void Main()
        {
            XDocument xmlDoc = XDocument.Load("../../catalog.xml");

            var albumPrices =
                from album in xmlDoc.Descendants("album")
                where int.Parse((album.Element("year").Value)) >= (DateTime.Now.Year - 5)
                select new
                {
                    Title = album.Element("name").Value,
                    Price = album.Element("price").Value
                };
            
            Console.WriteLine("The prices of the albums pubished after: {0}", (DateTime.Now.Year - 5));
            foreach (var album in albumPrices)
            {
                Console.WriteLine("The album: " + album.Title + " costs: " + album.Price);
            }
        }
    }
}
