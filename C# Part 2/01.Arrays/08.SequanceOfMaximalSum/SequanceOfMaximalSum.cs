using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that finds the sequence of maximal sum in given array. Example:
//	{2, 3, -6, -1, 2, -1, 6, 4, -8, 8} -> {2, -1, 6, 4}


class SequanceOfMaximalSum
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
        
        int maxSum = array[0];
        int currSum = array[0];
        int currentSequence = 1;
        int sequenceEnd = 1;
        int start = 0;
        int startTemp = 0;

        for (int i = 1; i < array.Length -1 ; i++)
        {
            if (currSum + array[i] > array[i])
            {
                currSum = maxSum + array[i];
                currentSequence++;
            }
            else
            {
                startTemp = i;
                currentSequence = 1;
                currSum = array[i];
            }

            if (currSum > maxSum)
            {
                maxSum = currSum;
                sequenceEnd = currentSequence;
                start = startTemp;
            }
        }

        for (int i = start; i < start + sequenceEnd; i++)
        {
            Console.Write(array[i] + " ");
        }
        //------------------------------------------------------
       /* int max = array[0];
        int maxEnd = array[0];
        int longSequence = 1;
        int currentSequence = 1;
        int start = 0;
        int startTemp = 0;

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] + maxEnd > array[i])
            {
                maxEnd = array[i] + maxEnd;
                currentSequence++;
            }

            else
            {
                maxEnd = array[i];
                startTemp = i;
                currentSequence = 1;
            }

            if (maxEnd > max)
            {
                max = maxEnd;
                longSequence = currentSequence;
                start = startTemp;
            }
        }

        Console.WriteLine(max);

        for (int i = start; i < start + longSequence; i++)
        {
            Console.Write(array[i] + " ");
        }*/
    }
}

