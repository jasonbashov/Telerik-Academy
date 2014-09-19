using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.
//Example: "aaaaabbbbbcdddeeeedssaa" -> "abcdedsa".

namespace _23.RemovingIdentical
{
    class RemoveIdenticalLetters
    {
        static void Main()
        {
            Console.WriteLine("Enter your string:");
            string text = Console.ReadLine();

            StringBuilder newString = new StringBuilder();

            newString.Append(text[0]);
            for (int i = 1; i < text.Length; i++)
            {
                if (text[i] != text[i - 1])
                {
                    newString.Append(text[i]);
                }
            }

            Console.WriteLine(newString);
        }
    }
}
