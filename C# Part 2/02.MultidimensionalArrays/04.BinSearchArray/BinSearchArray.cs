using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program, that reads from the console an array of N integers and an integer K, 
//sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K. 

class BinSearchArray
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

        Console.WriteLine("Enter K: ");
        int k = int.Parse(Console.ReadLine());
        int element = k;

        Array.Sort(array);


        int index = -1; 

        do
        {
            index = Array.BinarySearch(array, element);
            if (index < 0)
            {
                element--;
            }
        } while (index < 0);

        

        for (int i = index; i >= 0; i--)
        {
            if (array[i] <= element)
            {
                Console.WriteLine("The largest number <= {0} in the array is {1}", k, array[i]);
                i = 0;
            }
        }

    }
}

