using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that compares two char arrays lexicographically (letter by letter).

class CharArraysComparement
{
    static void Main()
    {
        //identical arrays
        char[] firstArray = { 'a', 'b', 'c', 'd' };
        char[] secondArray = { 'a', 'b', 'c', 'd' };

        //non-indentical arrays
        char[] thirdArray = { 'e', 'f', 'g', 'h' };
        char[] fourthArray = { 'e', 'f', 'f', 'f' };

        bool isEqual = true;

        //comparing

        for (int i = 0; i < firstArray.Length; i++)
        {
            if (firstArray[i] != secondArray[i])
            {
                isEqual = false;
                break;
            }
        }

        if (isEqual)
        {
            Console.WriteLine("The first two arrays are the same!");
        }
        else
        {
            Console.WriteLine("The first two arrays are NOT the same!");
        }

        isEqual = true;

        for (int i = 0; i < firstArray.Length; i++)
        {
            if (thirdArray[i] != fourthArray[i])
            {
                isEqual = false;
                break;
            }
        }

        if (isEqual)
        {
            Console.WriteLine("The second two arrays are the same!");
        }
        else
        {
            Console.WriteLine("The second two arrays are NOT the same!");
        }
    }
}


