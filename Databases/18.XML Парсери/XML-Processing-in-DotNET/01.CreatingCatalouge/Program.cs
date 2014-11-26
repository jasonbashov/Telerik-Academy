namespace CreatingCatalouge
{
    using System.Xml.Linq;

    //01.Create a XML file representing catalogue. The catalogue should contain albums of different artists. 
    //For each album you should define: name, artist, year, producer, price and a list of songs.
    //Each song should be described by title and duration.

    class Program
    {
        static void Main()
        {
            XNamespace ns = "http://catalouge.net";

            XElement catalougeXml = new XElement(
                XName.Get("albums", "http://atrtists.org"));
            XElement albumLINQ = new XElement(ns + "album",
                new XElement(ns + "name", "Nevermind"),
                new XElement(ns + "artist", "Nirvana"),
                new XElement(ns + "year", "1991"),
                new XElement(ns + "producer", "Butch Vig"),
                new XElement(ns + "price", "19.99"),
                new XElement(ns + "songs",
                    new XElement(ns + "song", 
                        new XElement("title", "Smells Like Teen Spirit"),
                        new XElement("duration", "4:38")),
                    new XElement(ns + "song", 
                        new XElement("title", "Come as You Are"),
                        new XElement("duration", "3:28")),
                    new XElement(ns + "song", 
                        new XElement("title", "Lithium"),
                        new XElement("duration", "3:18")),
                    new XElement(ns + "song", 
                        new XElement("title", "In Bloom"),
                        new XElement("duration", "3:38"))));
            catalougeXml.Add(albumLINQ);

            albumLINQ = new XElement(ns + "album",
                new XElement(ns + "name", "In Utero"),
                new XElement(ns + "artist", "Nirvana"),
                new XElement(ns + "year", "1993"),
                new XElement(ns + "producer", "Steve Albini"),
                new XElement(ns + "price", "29.99"),
                new XElement(ns + "songs",
                    new XElement(ns + "song", 
                        new XElement("title", "Heart-Shaped Box"),
                        new XElement("duration", "3:48")),
                    new XElement(ns + "song", 
                        new XElement("title", "Rape Me"),
                        new XElement("duration", "2:58")),
                    new XElement(ns + "song", 
                        new XElement("title", "Pennyroyal Tea"),
                        new XElement("duration", "3:18")),
                    new XElement(ns + "song", 
                        new XElement("title", "All Apologies"),
                        new XElement("duration", "3:23"))));

            catalougeXml.Add(albumLINQ);
            //System.Console.WriteLine(catalougeXml);

            catalougeXml.Save("../../catalouge.xml");
        }
    }
}
