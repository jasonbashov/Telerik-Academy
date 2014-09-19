using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method that returns the index of the first element in array that is bigger than its neighbors, or -1,
//if there’s no such element.

class IndexReturn
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

    static int IsBigger(int[] givenArray, int position)
    {
        if (givenArray[position] > givenArray[position - 1] && givenArray[position] > givenArray[position + 1])
        {
            return position;
        }
        else
        {
            return (-1);
        }
    }

    static void Main()
    {
        FillArray();

        //Console.WriteLine("Enter position(zero based): ");

        int position = 0;

        for (int i = 1; i < array.Length - 1; i++)
        {
            position = IsBigger(array,i);

            if (position != (-1))
            {
                Console.WriteLine("The position of the first element bigger than its neighbors is: {0}", position);
                break;
            }
        }

        if (position == (-1))
        {
            Console.WriteLine("There is no such element");
        }
    }
}

