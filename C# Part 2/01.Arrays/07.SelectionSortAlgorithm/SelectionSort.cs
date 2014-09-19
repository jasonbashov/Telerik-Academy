using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Sorting an array means to arrange its elements in increasing order. 
//Write a program to sort an array. Use the "selection sort" algorithm: 
//Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.


class SelectionSort
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the array's length N:");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        Console.WriteLine("Fill the array:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine("Enter index {0} value:", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        int smallestElement = 0;
        int temp = 0;

        //"selection sort" algorithm: 

        for (int j = 0; j < n; j++)
        {
            smallestElement = array[j];

            for (int i = j + 1; i < array.Length; i++)
            {
                if (array[i]  < smallestElement)
                {
                    smallestElement = array[i];

                    if (array[i]  <= smallestElement)
                    {
                        temp = array[j];
                        array[j] = array[i];
                        array[i] = temp;
                    }
                    
                }
            }
        }

        foreach (int number in array)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();

    }
}

