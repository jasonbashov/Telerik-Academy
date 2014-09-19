using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".

namespace _20.PolindromesChecking
{
    class CheckingForPolidromes
    {
        static bool IsPalindrome(string str)
        {
            for (int i = 0; i < str.Length / 2; i++)
                if (str[i] != str[str.Length - 1 - i])
                    return false;

            return true;
        }

        static void Main()
        {
            string text = "hare we are going to type some abba words lamal polindromes are going oto be some of them exe like and some are not anna";

            string[] words = text.Split(' ', '.', ';', '!', '?', ',');

            foreach (var word in words)
            {
                if (IsPalindrome(word))
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}
