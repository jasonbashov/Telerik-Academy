using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RssFeedParsingConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create web client.
            WebClient client = new WebClient();

            //Task02
            client.DownloadFile("http://forums.academy.telerik.com/feed/qa.rss", "telerikForumRss.xml");
            Console.WriteLine("File downloaded");

            var path = "telerikForumRss.xml";

            var doc = XDocument.Load(path);

            //Task03
            string json = JsonConvert.SerializeXNode(doc,Newtonsoft.Json.Formatting.Indented);
            var jsonObj = JObject.Parse(json);
            Console.WriteLine("RSS parsed successfuly from xml to JSON");
            //uncomment to see the parsed JSON in the console (not very readable though)
            //Console.WriteLine(jsonObj);

            //Task04
            var questionTitles = jsonObj["rss"]["channel"]["item"].Select(t => t["title"]);
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("****************************Task 04 Questions****************************");
            Console.WriteLine("*************************************************************************");
            foreach (var question in questionTitles)
            {
                Console.WriteLine(question.ToString());
            }

            //Task05
            var poco = JsonConvert.DeserializeObject<RootObject>(json);
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("****************************Task 05 Questions****************************");
            Console.WriteLine("*************************************************************************");
            foreach (var item in poco.Rss.Channel.Item)
            {
                Console.WriteLine(item.Title);
            }
            
            //Task06
            StringBuilder html = new StringBuilder("<body>\n\t<ul>\n");
            foreach (var item in poco.Rss.Channel.Item)
            {
                html.AppendLine("\t\t<li>Question : " + item.Title + " Category : " + item.Category + "Link : " + item.Link+"</li>");
            }

            html.AppendLine("\t</ul>\n</body>");
            File.WriteAllText("forumPage.html", html.ToString());
            Console.WriteLine("Html created successfuly");
        }
    }
}
