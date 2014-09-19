using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

//Write a program that deletes from a text file all words that start with the prefix "test".
//Words contain only the symbols 0...9, a...z, A…Z, _.

class WordsPrefixDeleter
{
    static void Main()
    {
        var fs = File.Open(@"..\..\TextFile.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
        var sw = new StreamWriter(fs);
        var sr = new StreamReader(fs);

        using (sr)
        {
            using (sw)
            {
                for (string line; (line = sr.ReadLine()) != null; )
                    sw.WriteLine(Regex.Replace(line, @"\btest\w*\b", String.Empty));
            }
        }
        fs.Close();
    }
}

