using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//Write a program that reads a text file and inserts line numbers in front of each of its lines.
//The result should be written to another text file.

namespace _03.AddingLines
{
    class AddingLines
    {
        static void Main()
        {
            StreamReader reader = new StreamReader("FileToBeRead.txt");
            StreamWriter streamWriter = new StreamWriter("FileToWrite.txt");

            using (streamWriter)
            {
                using (reader)
                {
                    int lineNumber = 1;
                    string line = "something";
                    while (line != null)
                    {
                        line = reader.ReadLine();
                        streamWriter.WriteLine("Line {0}: {1}", lineNumber, line);
                        lineNumber++;
                    }
                }
            }
        }
    }
}
