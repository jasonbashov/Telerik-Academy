using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method that return the maximal element in a portion of array of integers starting at given index. 
//Using it write another method that sorts an array in ascending / descending order.


class PortionMaxElement
{
    static int[] array;
    static int maxElementIndex = 0;

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

    static void PrintArray(int[] arrayToBePrinted)
    {
        foreach (int num in arrayToBePrinted)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }

    static int FindMax(int[] arrayOfInt, int index, int portion)
    {
        int max = int.MinValue;

        max = arrayOfInt[index];

        for (int i = index; i < portion; i++)
        {
            if (max <= arrayOfInt[i])
            {
                max = arrayOfInt[i];
                maxElementIndex = i;
            }
        }
        return max;
    }


    static int[] DescendingOrder(int[] arrayOfInt)
    {
        for (int i = 0; i < arrayOfInt.Length; i++)
        {
            int temp = arrayOfInt[i];
            arrayOfInt[i] = FindMax(arrayOfInt, i, arrayOfInt.Length);
            arrayOfInt[maxElementIndex] = temp;
        }

        return arrayOfInt;
    }

    static int[] AscendingOrder(int[] arrayOfInt)
    {
        arrayOfInt = DescendingOrder(arrayOfInt);

        Array.Reverse(arrayOfInt);

        return arrayOfInt;
    }

    static void Main()
    {
        FillArray();

        int portion = 0;
        int choice = 3;
        
        Console.WriteLine("Enter index:");
        int index = int.Parse(Console.ReadLine());

        int border = array.Length - index + 1;

        do
        {
            Console.WriteLine("Enter portion < {0} : ",border);
            portion = int.Parse(Console.ReadLine());

        } 
        while (portion >= border);

        Console.WriteLine("The max element in the portion is: {0}",FindMax(array,index,portion));

        do
        {
            Console.WriteLine("***********************");
            Console.WriteLine("1. Descending");
            Console.WriteLine("2. Ascending");
            Console.WriteLine("3. Exit");
            Console.WriteLine("Make your choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    array = DescendingOrder(array);
                    PrintArray(array);
                    break;
                case 2:
                    array = AscendingOrder(array);
                    PrintArray(array);
                    break;
                default: break;
            }
        }
        while (choice != 3);
        
        
    }
}

