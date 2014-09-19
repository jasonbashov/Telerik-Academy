using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

//Write a program that finds how many times a substring is contained in a given text (perform case insensitive search).

namespace _04.SubstringCount
{
    class SubstringCount
    {

        static void Main()
        {
            var fs = File.Open(@"..\..\Text.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            var sr = new StreamReader(fs);
            int counter = 0;
            int result = 0;

            Console.WriteLine("Enter your substring:");
            string substring = Console.ReadLine();

            using (sr)
            {
                string line = sr.ReadLine();
                while (line != null)
                {
                    counter = Regex.Matches(line, substring, RegexOptions.IgnoreCase).Count;
                    result += counter;
                    line = sr.ReadLine();
                }
            }

            Console.WriteLine("The substring is met {0} times in the text:", result);
            fs.Close();
        }
    }
}
