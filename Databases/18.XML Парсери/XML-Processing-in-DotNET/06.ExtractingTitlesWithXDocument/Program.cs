namespace ExtractingTitlesWithXDocument
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml;
    using System.Xml.Linq;

    //06.Rewrite the same using XDocument and LINQ query.
    class Program
    {
        static void Main()
        {
            XDocument xmlDoc = XDocument.Load("../../catalog.xml");

            var songTitles =
                from song in xmlDoc.Descendants("album").Descendants("songs").Descendants("song")
                select new
                {
                    Title = song.Element("title").Value,
                };
            
            Console.WriteLine("Song titles in the catalog:");
            foreach (var songTitle in songTitles)
            {
                Console.WriteLine(songTitle.Title);
            }
        }
    }
}
