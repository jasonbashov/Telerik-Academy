using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

//Write a program that parses an URL address given in the format:
//      [protocol]://[server]/[resource]
//and extracts from it the [protocol], [server] and [resource] elements. 

namespace _12.URLExtraction
{
    class UrlExtraction
    {
        static void Main()
        {
            string urlAdress = "http://www.devbg.org/forum/index.php";

            var fragments = Regex.Match(urlAdress, "(.*)://(.*?)(/.*)").Groups;

            foreach (var word in fragments)
            {
                Console.WriteLine(word);
            }
        }
    }
}
