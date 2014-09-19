using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that finds the maximal increasing sequence in an array. Example: {3, 2, 3, 4, 2, 2, 4} -> {2, 3, 4}.

class IncreasingSequense
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

        for (int i = 0; i < n - 1; i++)
        {
            if (array[i] +1 == array[i + 1])
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
