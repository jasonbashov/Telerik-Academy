using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

//Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.

namespace _25.HtmlTextExtracting
{
    class HtmlTextExtractig
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader(@"..\..\htmlText.html");

            using (reader)
            {
                string line = string.Empty;
                MatchCollection matchProtocolAndSiteName = Regex.Matches(line, @"(?<=^|>)[^><]+?(?=<|$)");
                while ((line = reader.ReadLine()) != null)
                {
                    matchProtocolAndSiteName = Regex.Matches(line, @"(?<=^|>)[^><]+?(?=<|$)");

                    foreach (var word in matchProtocolAndSiteName)
                        Console.WriteLine(word);

                }
            }
        }
    }
}
