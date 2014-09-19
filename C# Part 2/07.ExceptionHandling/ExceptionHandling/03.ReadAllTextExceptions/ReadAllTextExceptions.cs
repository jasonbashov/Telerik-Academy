using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), 
//reads its contents and prints it on the console. Find in MSDN how to use System.IO.File.ReadAllText(…).
//Be sure to catch all possible exceptions and print user-friendly error messages.

namespace _03.ReadAllTextExceptions
{
    class ReadAllTextExceptions
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter file path: (e.g. C:\\WINDOWS\\win.ini):");
                var filePath = Console.ReadLine();
                var openFile = File.ReadAllText(filePath);

                string readText = File.ReadAllText(filePath);

                Console.WriteLine(readText);

            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Path is null");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Path is a zero-length string, contains only white space");
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("Path location max length reached");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("The specified path is invalid");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file specified in path was not found.");
            }
            catch (IOException)
            {
                Console.WriteLine("An I/O error occurred while opening the file");
            }
            
            
        }
    }
}
