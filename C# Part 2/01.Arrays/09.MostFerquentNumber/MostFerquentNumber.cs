using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that finds the most frequent number in an array. Example:
//	{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3} -> 4 (5 times)


class MostFerquentNumber
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

        int currNumberCount = 0;
        int maxNumberCount = 0;
        int currNumber = 0;
        int searchedNumber = 0;

        Array.Sort(array);

        
        
        for (int i = 0; i < array.Length; i++)
        {
            currNumberCount = 0;
            for (int j = i; j < array.Length; j++)
            {
                if (array[i] ==  array[j])
                {
                    currNumber = array[i];
                    currNumberCount++;
                }

                if (currNumberCount > maxNumberCount)
                {
                    searchedNumber = currNumber;
                    maxNumberCount = currNumberCount;
                }
            }
        }

        Console.WriteLine("{0} ({1} times)", searchedNumber, maxNumberCount);

    }
}

