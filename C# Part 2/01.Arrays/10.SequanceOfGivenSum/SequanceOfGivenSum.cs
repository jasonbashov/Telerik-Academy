using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that finds in given array of integers a sequence of given sum S (if present). 
//Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11 -> {4, 2, 5}	


class SequanceOfGivenSum
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

        Console.WriteLine("Enter the needed sum S:");
        int s = int.Parse(Console.ReadLine());

        int seqStart = 0;
        int seqEnd = 0;
        int currSum = array[0];
        bool isMatch = false;

        for (int i = 1; i < array.Length; i++)
        {
            if (currSum + array[i] < s )
            {
                currSum += array[i];
            }
            else if (currSum + array[i] == s)
            {
                seqEnd = i;
                isMatch = true;
                break;
            }
            else
            {
                seqStart = i;
                i--;
                currSum = 0;
            }
        }

        if (isMatch)
        {
            Console.WriteLine("The sequance with sum {0}", s);
            for (int i = seqStart; i <= seqEnd; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("No present sequance with the sum {0}", s);
        }
    }
}

