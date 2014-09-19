using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

//Write a program that reverses the words in given sentence.
//	Example: "C# is not C++, not PHP and not Delphi!" -> "Delphi not and PHP, not C++ not is C#!".

namespace _13.SentenceReverse
{
    class SentenceReverse
    {
        static void Main()
        {
            string sentence = "C# is not C++, not PHP and not Delphi!";
            var words = Regex.Split(sentence, @"\W+");

            string[] signs = sentence.Split(words, StringSplitOptions.RemoveEmptyEntries);

            Array.Reverse(words);
            StringBuilder strWordsReversed = new StringBuilder();

            for (int i = 0; i < signs.Length; i++)
            {
                strWordsReversed.Append(words[i]);
                strWordsReversed.Append(signs[i]);
            }
            Console.WriteLine(strWordsReversed.ToString());
            
        }
    }
}
