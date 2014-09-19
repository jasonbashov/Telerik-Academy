using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
//Write a program that downloads a file from Internet (e.g. http://www.devbg.org/img/Logo-BASD.jpg) 
//and stores it the current directory. Find in Google how to download files in C#. 
//Be sure to catch all exceptions and to free any used resources in the finally block.

namespace _04.FileDownload
{
    class FileDownload
    {
        static void Main(string[] args)
        {
            try
            {
                string webAdress = "http://www.devbg.org/img/Logo-BASD.jpg";
                WebClient webClient = new WebClient();
                webClient.DownloadFile(webAdress, @"..\..\Logo-BASD.jpg");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("The address parameter is null.");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("The address parameter is not valid.");
            }
            catch (WebException)
            {
                Console.WriteLine("WebException");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("NotSupportedException");
            }
        }
    }
}
