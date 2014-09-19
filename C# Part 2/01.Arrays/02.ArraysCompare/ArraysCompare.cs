using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads two arrays from the console and compares them element by element.


class ArraysCompare
{
    static void Main()
    {
        Console.WriteLine("Enter arrays' length:");
        int n = int.Parse(Console.ReadLine());

        int[] firstArray = new int[n];
        int[] secondArray = new int[n];

        bool isEqual = true;
        
        Console.WriteLine("Full first array: ");

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter {0} element: ",i);
            firstArray[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Full second array: ");

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter {0} element: ", i);
            secondArray[i] = int.Parse(Console.ReadLine());
        }

        //comparing arrays

        for (int i = 0; i < n; i++)
        {
            if (firstArray[i] == secondArray[i])
            {
                Console.WriteLine("Elements with index {0} of the two arrays are equal: {1}", i, firstArray[i]);
            }
            else
            {
                Console.WriteLine("Index {0}: First array: {1} Second array: {2}", i, firstArray[i], secondArray[i]);
                isEqual = false;
            }
        }

        if (isEqual)
        {
            Console.WriteLine("The two arrays are equal");
        }
        else
        {
            Console.WriteLine("The two arrays are NOT equal");
        }

    }
}

