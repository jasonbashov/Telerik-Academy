using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads a string, reverses it and prints the result at the console.
//Example: "sample" -> "elpmas".

namespace _02.ReverseString
{
    class ReversingStrings
    {
        public static string Reverse(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        static void Main()
        {
            Console.WriteLine("Enter your string:");
            string str = Console.ReadLine();

            str = Reverse(str);

            Console.WriteLine(str);
        }
    }
}
