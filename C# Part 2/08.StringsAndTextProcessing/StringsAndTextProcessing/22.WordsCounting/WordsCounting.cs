using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads a string from the console and lists all different words in the string along with
//information how many times each word is found.

namespace _22.WordsCounting
{
    class WordsCounting
    {
        static void Main()
        {
            string text = "here, we are going to type. abba words lamal polindromes are going! oto be some of them exe? like here and there and some are not anna";

            List<string> wordsList = new List<string>();

            char[] separators = {',', ' ', '.', '?', '!'};
            string[] words = text.Split(separators,StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> diction = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (diction.ContainsKey(word))
                {
                    diction[word] = diction[word] + 1;
                }
                else 
                {
                    diction.Add(word, 1);
                }
            }

            foreach (var word in diction)
            {
                Console.WriteLine("{0,-15} - {1} times", word.Key, word.Value);
            }
        }
    }
}
