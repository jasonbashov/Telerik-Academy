using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

//Write a program that extracts from given XML file all the text without the tags

class XmlText
{
    static void Main()
    {
        var fs = File.Open(@"..\..\file.xml", FileMode.OpenOrCreate, FileAccess.Read);
        var sr = new StreamReader(fs);

        using (sr)
        {
            string line = string.Empty;
            MatchCollection mathText = Regex.Matches(line, @"(?<=^|>)[^><]+?(?=<|$)");
            while ((line = sr.ReadLine()) != null)
            {
                mathText = Regex.Matches(line, @"(?<=^|>)[^><]+?(?=<|$)");

                foreach (var word in mathText)
                {
                    Console.WriteLine(word);
                }
            }
        }
        fs.Close();
    }
}

