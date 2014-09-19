using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads two numbers N and K and generates all the combinations of K distinct elements from the set [1..N]. Example:
//	N = 5, K = 2 -> {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}

class Combinations
{
    static int N = int.Parse(Console.ReadLine());
    static int K = int.Parse(Console.ReadLine());

    //generates variations
    static void Combination(int[] array, int index, int currentNumber)
    {
        if (index == array.Length)
        {
            PrintArray(array);
        }
        else
        {
            for (int i = currentNumber; i <= N; i++)
            {
                array[index] = i;
                Combination(array, index + 1, i + 1);
            }
        }
    }

    //prints array
    static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }

    static void Main()
    {
        int[] array = new int[K];
        Combination(array, 0, 1);
    }
}

