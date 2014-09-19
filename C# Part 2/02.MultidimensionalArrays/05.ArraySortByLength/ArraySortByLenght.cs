using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//You are given an array of strings.
//Write a method that sorts the array by the length of its elements (the number of characters composing them).

class ArraySortByLenght
{
    static string[] stringArray = { "asd", "shalqlq", "fthepolice", "shalqlqlq", "wtf", "aa", "bomb" };

    static void QuickSort(string[] arrayToBeSorted)
    {
        string temp = "0";

        for (int i = 0; i < arrayToBeSorted.Length; i++)
        {
            for (int j = i; j < arrayToBeSorted.Length; j++)//tozi cikyl tursi za po-golemite 4isla ot segashnoto
            {
                if (arrayToBeSorted[j].Length > arrayToBeSorted[i].Length)
                {
                    for (int jj = arrayToBeSorted.Length - 1; jj > j; jj--)//s tozi cikyl se tyrsi ot kraq na masiva kym nachaloto za po-malko 4islo
                    {
                        if (arrayToBeSorted[jj].Length < arrayToBeSorted[i].Length)
                        {
                            temp = arrayToBeSorted[jj];
                            arrayToBeSorted[jj] = arrayToBeSorted[j];
                            arrayToBeSorted[j] = temp;
                            break;
                        }
                    }
                }
                if (arrayToBeSorted[j].Length < arrayToBeSorted[i].Length)
                {
                    temp = arrayToBeSorted[i];
                    arrayToBeSorted[i] = arrayToBeSorted[j];
                    arrayToBeSorted[j] = temp;
                }
            }
        }
    }

    static void Main()
    {
        QuickSort(stringArray);

        foreach (string word in stringArray)
        {
            Console.Write(word + "; ");
        }
        Console.WriteLine();
    }
}

