using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file. Example:
//Ivan			George
//Peter		->	Ivan
//Maria			Maria
//George		Peter

class SortingNames
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\Names.txt");
        StreamWriter streamWriter = new StreamWriter(@"..\..\SortedNames.txt");
        List<string> names = new List<string>();

        using (streamWriter)
        {
            using (reader)
            {
                string line = reader.ReadLine();

                while (line != null)
                {
                    names.Add(line);
                    line = reader.ReadLine();
                }
                names.Sort();

                foreach (string name in names)
                {
                    streamWriter.WriteLine(name);
                }
            }
        }
    }
}

