using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//* We are given an array of integers and a number S. Write a program to find if there exists a subset
//of the elements of the array that has a sum S. Example:
//	arr={2, 1, 2, 4, 3, 5, 2, 6}, S=14 -> yes (1+2+5+6)


class ExistingSubsets
{
    static void Main()
    {
        //int[] array = { 2, 1, 2, 4, 3, 5, 2, 6 };

        Console.WriteLine("Enter the array's length N:");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        Console.WriteLine("Fill the array:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine("Enter index {0} value:", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter S:");
        int neededSum = int.Parse(Console.ReadLine());

        string subset = "";
        bool isThereSubset = false;

        int numberOfElements = array.Length;

        int maxSubsets = (int)Math.Pow(2, numberOfElements) - 1; //opredelqme maximalniq broi na podmnojestvata

        for (int i = 1; i <= maxSubsets; i++)
        {
            subset = "";
            long checkingSum = 0;
            
            for (int j = 0; j < numberOfElements; j++)
            {
                int mask = 1 << j;
                int nAndMask = i & mask;
                int bit = nAndMask >> j;
                if (bit == 1)//ako 1viq bit na 4isloto e edinica, zna4i moje da u4astva v dadenoto podmnojestvo
                {
                    checkingSum = checkingSum + array[j];
                    subset = subset + " " + array[j];
                }
            }
            if (checkingSum == neededSum)
            {
                Console.WriteLine("Yes ->" + subset);
                isThereSubset = true;
            }
        }

        if (!isThereSubset)
        {
            Console.WriteLine("A subset with sum {0} does not exist", neededSum);
        }
    } 
}

