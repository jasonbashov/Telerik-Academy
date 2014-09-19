using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//Write a program that replaces all occurrences of the substring "start" with the substring "finish" in a text file. 
//Ensure it will work with large files (e.g. 100 MB).

class Program
{
    static void Main()
    {
        /*StreamReader reader = new StreamReader(@"..\..\SomeTextFile.txt");
        StreamWriter streamWriter = new StreamWriter(@"..\..\TextFile.txt");*/
        List<string> names = new List<string>();

        var fs = File.Open(@"..\..\SomeTextFile.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
        var sw = new StreamWriter(fs);
        var sr = new StreamReader(fs);

        using (sr)
        {
            using (sw)
            {
                string line = sr.ReadLine();

                while (line != null)
                {
                    string replacement = line.Replace("start", "finish");
                    sw.WriteLine(replacement);
                    line = sr.ReadLine();
                }
            }
        }
        fs.Close();
    }
}

