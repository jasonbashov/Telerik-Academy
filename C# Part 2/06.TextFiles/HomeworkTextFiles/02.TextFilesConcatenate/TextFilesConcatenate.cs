using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//Write a program that concatenates two text files into another text file.

namespace _02.TextFilesConcatenate
{
    class TextFilesConcatenate
    {
        static void Main()
        {
            StreamReader reader1 = new StreamReader("file1.txt");
            StreamWriter streamWriter = new StreamWriter("result.txt");

            using (streamWriter)
            {


                using (reader1)
                {

                    string line = "something";
                    while (line != null)
                    {
                        line = reader1.ReadLine();

                        streamWriter.WriteLine(line);
                    }


                }
                reader1 = new StreamReader("file2.txt");

                using (reader1)
                {

                    string line = "something";
                    while (line != null)
                    {
                        line = reader1.ReadLine();

                        streamWriter.WriteLine(line);
                    }


                }
            }
        }
    }
}
