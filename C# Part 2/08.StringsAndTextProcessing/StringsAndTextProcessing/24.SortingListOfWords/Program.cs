using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

//Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

namespace _24.SortingListOfWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string textWords = "we are going to write in some words to test the program";

            string[] words = textWords.Split(' ');

            Array.Sort(words);

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
