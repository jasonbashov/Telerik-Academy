using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//Write a program that deletes from given text file all odd lines. The result should be in the same file.

class Program
{
    static void Main()
    {
        var fs = File.Open(@"..\..\SomeTextFile.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
        var sw = new StreamWriter(fs);
        var sr = new StreamReader(fs);

        int counterLines = 1;

        using (sr)
        {
            using (sw)
            {
                string line = sr.ReadLine();

                while (line != null)
                {
                    if (counterLines%2 == 0)
                    {
                        sw.WriteLine(line);
                    }
                    else
                    {
                        sw.WriteLine();
                    }

                    counterLines++;
                    line = sr.ReadLine();
                }
            }
        }


        fs.Close();
    }
}

