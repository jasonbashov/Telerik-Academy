using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that creates an array containing all letters from the alphabet (A-Z).
//Read a word from the console and print the index of each of its letters in the array.

class AlphabetArray
{
    static void Main()
    {
        char[] alphabetCapArray = new char[26];
        char[] alphabetMinArray = new char[26];
        char asciiValue = 'A';
        int index = 0;

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

        Console.WriteLine("Enter a word: ");
        string word = Console.ReadLine();

        for (int i = 0; i < word.Length; i++)
        {
            if (word[i] >= 'A' && word[i] <= 'Z')
            {
                index = Array.BinarySearch(alphabetCapArray, word[i]);
                Console.WriteLine("'{0}' index is {1}", word[i], index);
            }
            else if (word[i] >= 'a' && word[i] <= 'z')
            {
                index = Array.BinarySearch(alphabetMinArray, word[i]);
                Console.WriteLine("'{0}' index is {1}", word[i], index);
            }
            else
            {
                Console.WriteLine("END");
                break;
            }
        }



        /*
        for (int i = 0; i < alphabetCapArray.Length; i++)
        {
            Console.WriteLine(alphabetCapArray[i]);
        }
        for (int i = 0; i < alphabetCapArray.Length; i++)
        {
            Console.WriteLine(alphabetMinArray[i]);
        }*/
    }
}

