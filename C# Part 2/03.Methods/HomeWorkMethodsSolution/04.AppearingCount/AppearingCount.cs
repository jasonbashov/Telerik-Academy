using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method that counts how many times given number appears in given array. 
//Write a test program to check if the method is working correctly.

class AppearingCount
{
    static int[] array;

    static void FillArray()
    {
        Console.WriteLine("Enter the array's length N:");
        int n = int.Parse(Console.ReadLine());

        array = new int[n];

        Console.WriteLine("Fill the array:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine("Enter index {0} value:", i);
            array[i] = int.Parse(Console.ReadLine());
        }

    }

    static int CountNumber(int[] arrayOfIntegers, int givenNumber)
    {
        int count = 0;

        foreach (int num in arrayOfIntegers)
        {
            if (num == givenNumber)
            {
                count++;
            }
        }
        return count;
    }

    static void Main()
    {
        Console.WriteLine("Give the number: ");
        int number = int.Parse(Console.ReadLine());

        FillArray();

        int count = CountNumber(array, number);

        Console.WriteLine("The number {0} appears {1} times", number, count);
    }
}

