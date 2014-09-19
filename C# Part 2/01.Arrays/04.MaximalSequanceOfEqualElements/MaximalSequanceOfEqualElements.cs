using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that finds the maximal sequence of equal elements in an array.
//	Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1} -> {2, 2, 2}.

class MaximalSequanceOfEqualElements
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the array's length:");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];
        int count = 0;
        int MaxCount = 0;
        int arrayIndexStart = 0;
        int arrayIndexEnd = 0;

        Console.WriteLine("Fill the array:");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter index {0} value:", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        //comparing

        for (int i = 0; i < n - 1; i++)
        {
            if (array[i] == array[i + 1])
            {
                count++;
                if (count == 1)
                {
                    arrayIndexStart = i; //nachaloto na tyrsenata ot nas redica
                }
                if (count > MaxCount)
                {
                    MaxCount = count;
                    arrayIndexEnd = i + 1; //krai na tyrsenata ot nas redica
                }
            }
            else
            {
                count = 0;
            }
        }

        //Output
        Console.WriteLine("Input array:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine("The maximal sequence of equal elements:");
        for (int i = arrayIndexStart; i <= arrayIndexEnd; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }

}

