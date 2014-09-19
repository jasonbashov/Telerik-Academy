using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method that checks if the element at given position in given array of integers is bigger than its two neighbors
//(when such exist).

class NeighboursCompare
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

    static bool IsBigger(int[] givenArray, int position)
    {
        if (givenArray[position] > givenArray[position - 1] && givenArray[position] > givenArray[position + 1])
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    static void Main()
    {

        FillArray();

        Console.WriteLine("Enter position(zero based): ");
        int position = int.Parse(Console.ReadLine());

        if (position == 0 || position == array.Length - 1)
        {
            Console.WriteLine("The given element doesn't have two neighbours!");
        }
        else
        {
            if (IsBigger(array, position))
            {
                Console.WriteLine("The element {0} at position {1} is bigger than its two neighbors: {2} ; {3} "
                                           ,array[position], position, array[position - 1], array[position + 1]);
            }
            else
            {
                Console.WriteLine("The element {0} at position {1} is NOT bigger than its two neighbors: {2} ; {3} "
                                           , array[position], position, array[position - 1], array[position + 1]);
            }
        }
    }
}

