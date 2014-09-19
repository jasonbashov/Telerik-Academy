using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//Write a program that removes from a text file all words listed in given another text file. Handle all possible exceptions in your methods.

class RemoveWords
{
    static void Main()
    {
        var firstFile = File.Open(@"..\..\TextFile.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
        var secondFile = File.Open(@"..\..\ListedWords.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
        var sr2 = new StreamReader(secondFile);
        var sr = new StreamReader(firstFile);
        var sw = new StreamWriter(firstFile);
        var wordsInFirstFileList = new List<string>();
        var wordsInSecondFileList = new List<string>();

        using (sr)
        {
            using (sw)
            {
                using (sr2)
                {
                    string line = sr.ReadLine();

                    while (line != null)
                    {
                        string[] wordsInFile = line.Split(' ', '.', ',', '!', '?', ';', ':');
                        foreach (var word in wordsInFile)
                        {
                            wordsInFirstFileList.Add(word);
                        }
                        line = sr.ReadLine();
                    }

                    line = sr2.ReadLine();
                    while (line != null)
                    {
                        string[] wordsInFile = line.Split(' ', '.', ',', '!', '?', ';', ':');
                        foreach (var word in wordsInFile)
                        {
                            wordsInSecondFileList.Add(word);
                        }
                        line = sr2.ReadLine();
                    }

                    for (int i = 0; i < wordsInFirstFileList.Count; i++)
                    {
                        foreach (var word in wordsInSecondFileList)
                        {
                            if (wordsInFirstFileList[i] == word)
                            {
                                wordsInFirstFileList.Remove(word);
                            }
                        }
                    }
                    foreach (var word in wordsInFirstFileList)
                    {
                        sw.Write(word + " ");
                    }
                    sw.WriteLine();
                }
            }
        }
        firstFile.Close();
        secondFile.Close();
    }
}

