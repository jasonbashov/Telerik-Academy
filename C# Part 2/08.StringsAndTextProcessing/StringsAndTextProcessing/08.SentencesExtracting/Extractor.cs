using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

//Write a program that extracts from a given text all sentences containing given word.
//        Example: The word is "in". The text is:
//            "We are living in a yellow submarine. 
//             We don't have anything else. Inside the submarine is very tight. 
//             So we are drinking all the day. We will move out of it in 5 days."

//        The expected result is:
//            We are living in a yellow submarine.
//            We will move out of it in 5 days.
//        Consider that the sentences are separated by "." and the words – by non-letter symbols.

namespace _08.SentencesExtracting
{
    class Extractor
    {
        static List<string> sentecesList;//here we safe the sentences with the given word inside.

        public static string[] SplitSentences(string text)
        {
            string[] sentences = Regex.Split(text, @"(?<=[\.!\?])\s+");
            
            return sentences;
        }
        
        public static void SearchSentences(string text, string searchedWord)
        {
            string[] sentences = SplitSentences(text);
            sentecesList = new List<string>();

            foreach (var sentence in sentences)
            {
                string[] words = sentence.Split(' ', '.', ',', '!', '?', ';', ':');
                foreach (var word in words)
                {
                    if (word == searchedWord)
                    {
                        sentecesList.Add(sentence);
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            string givenWord = "in";
            string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";

            SearchSentences(text, givenWord);

            foreach (var sentence in sentecesList)
            {
                Console.WriteLine(sentence);
            }
        }
    }
}
