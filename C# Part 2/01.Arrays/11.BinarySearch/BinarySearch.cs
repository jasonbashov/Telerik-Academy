using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that finds the index of given element in a sorted array of integers
//by using the binary search algorithm (find it in Wikipedia).

class BinarySearch
{
    static void Main()
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

        Console.WriteLine("Give the element: ");
        int element = int.Parse(Console.ReadLine());

        Array.Sort(array);

        int index = Array.BinarySearch(array, element);

        Console.WriteLine("{0} is found at index: {1}.", element, index);
    }
}

