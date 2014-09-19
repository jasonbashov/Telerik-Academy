using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//Write a program that compares two text files line by line and prints the number of lines that are the same
//and the number of lines that are different. Assume the files have equal number of lines.

class TextFilesCompare
{
    static void Main()
    {
        StreamReader reader1 = new StreamReader("file1.txt");
        StreamReader reader2 = new StreamReader("file2.txt");

        int sameLinesCount = 0;
        int diffLinesCount = 0;
        using (reader1)
        {
            using (reader2)
            {
                string lineFirstFile = reader1.ReadLine();
                string lineSecondFile = reader2.ReadLine();

                while (lineFirstFile != null)
                {
                    lineFirstFile = reader1.ReadLine();
                    lineSecondFile = reader2.ReadLine();

                    if (lineFirstFile == lineSecondFile)
                    {
                        sameLinesCount++;
                    }
                    else
                    {
                        diffLinesCount++;
                    }
                }
            }
        }
        Console.WriteLine("Number of same lines: {0}", sameLinesCount);
        Console.WriteLine("Number of different lines: {0}", diffLinesCount);
    }
}

