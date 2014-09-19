using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to uppercase.
//The tags cannot be nested.

namespace _05.TagsRemoveAndUpper
{
    class UpperTextBetweenTags
    {
        public static string UpperCaseMethamorphosis(string stringToUpper)
        {
            int indexFirst = stringToUpper.IndexOf("<upcase>");
            int indexSecond = stringToUpper.IndexOf("</upcase>");

            string strToUpper = stringToUpper.Substring(indexFirst, indexSecond - indexFirst + 9);
            string upper = strToUpper.ToUpper();

            indexSecond = upper.IndexOf("</UPCASE>");
            upper = upper.Substring(8, indexSecond - 8);

            string replacement = stringToUpper.Replace(strToUpper, upper);
            return replacement;
        }
        static void Main()
        {

            var fs = File.Open(@"..\..\Text.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            var sr = new StreamReader(fs);
            using (sr)
            {
                string line = sr.ReadLine();

                while (line != null)
                {
                    while (line.IndexOf("<upcase>") != -1)
                    {
                        //string changedString 
                        line = UpperCaseMethamorphosis(line);
                    }

                    Console.WriteLine(line);
                    line = sr.ReadLine();
                    
                }
            }
            fs.Close();
        }
    }
}
