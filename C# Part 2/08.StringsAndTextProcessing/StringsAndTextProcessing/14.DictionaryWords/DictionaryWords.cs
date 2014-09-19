using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//A dictionary is stored as a sequence of text lines containing words and their explanations. 
//Write a program that enters a word and translates it by using the dictionary. 

namespace _14.DictionaryWords
{
    class DictionaryWords
    {
        static void Main()
        {
            string[,] dictionary = {{".NET","CLR","namespace"},
            {"platform for applications from Microsoft","managed execution environment for .NET","hierarchical organization of classes"}};

            string[] words = { "CLR", "namespace", ".NET" };

            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < dictionary.GetLength(1); j++)
                {
                    if (dictionary[0,j] == words[i])
                    {
                        Console.WriteLine("{0} -> {1}", words[i], dictionary[1,j]);
                    }
                }
            }
        }
    }
}
