using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads a string from the console and prints all different letters in the string 
//along with information how many times each letter is found. 

namespace _21.LettersCounting
{
    class LettersCounting
    {
        static void Main()
        {
            string text = "hare we are going to type some abba words lamal polindromes are going oto be some of them exe like and some are not anna";
            char[] alphabetCapArray = new char[26];
            int[] capLettersCount = new int[26];
            char[] alphabetMinArray = new char[26];
            int[] minLettersCount = new int[26];
            char asciiValue = 'A';
            

            for (int i = 0; i < alphabetCapArray.Length; i++)
            {
                alphabetCapArray[i] = asciiValue;
                asciiValue++;
            }

            asciiValue = 'a';
            for (int i = 0; i < alphabetCapArray.Length; i++)
            {
                alphabetMinArray[i] = asciiValue;
                asciiValue++;
            }

            char[] textArray = text.ToCharArray();

            
            for (int i = 0; i < textArray.Length; i++)
            {
                for (int j = 0; j < alphabetCapArray.Length; j++)
                {
                    if (textArray[i] == alphabetCapArray[j])
                    {
                        capLettersCount[j]++;
                    }
                    else if (textArray[i] == alphabetMinArray[j])
                    {
                        minLettersCount[j]++;
                    }
                }
            }

            for (int i = 0; i < alphabetCapArray.Length; i++)
            {
                Console.WriteLine("{0} is found {1} times", alphabetCapArray[i],capLettersCount[i]);
                Console.WriteLine("{0} is found {1} times", alphabetMinArray[i], minLettersCount[i]);
            }
        }
    }
}
