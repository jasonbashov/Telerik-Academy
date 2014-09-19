using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//Modify the solution of the previous problem to replace only whole words (not substrings).

class WholeWords
{
    static void Main()
    {
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
                    string[] words = line.Split(' ', '.', ',', '!', '?', ';', ':');

                    int i = 0;
                    foreach (string word in words)
                    {
                        if (word == "start")
                        {
                            words[i] = "finish";
                        }
                        i++;
                    }
                    foreach (var word in words)
                    {
                        sw.Write(word + " ");
                    }
                    sw.WriteLine();

                    line = sr.ReadLine();

                }
            }
        }
        fs.Close();
    }
}

