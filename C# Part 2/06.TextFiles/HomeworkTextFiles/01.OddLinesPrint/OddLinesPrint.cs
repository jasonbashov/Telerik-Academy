using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


//Write a program that reads a text file and prints on the console its odd lines.

namespace _01.OddLinesPrint
{
    class OddLinesPrint
    {
        static void Main()
        {
            StreamReader reader = new StreamReader("test.txt");
            using (reader)
            {
                //int lineNumber = 0;
                string line = "something";
                while (line != null)
                {
                    line = reader.ReadLine();
                    Console.WriteLine("{0}",line);
                    line = reader.ReadLine();
                }
            }

        }
    }
}
