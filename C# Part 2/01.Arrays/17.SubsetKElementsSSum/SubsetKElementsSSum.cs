using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//* Write a program that reads three integer numbers N, K and S and an array of N elements from the console. 
//Find in the array a subset of K elements that have sum S or indicate about its absence.


class SubsetKElementsSSum
{
    static void Main()
    {
        //Input
        Console.WriteLine("Enter the array's length N:");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter K:");
        int k = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter S:");
        int neededSum = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        Console.WriteLine("Fill the array:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine("Enter index {0} value:", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        //Solution //kato prednata zada4a, no s leki modifikacii

        List<int> subset = new List<int>();
        //string subset = "";
        bool isThereSubset = false;

        int numberOfElements = array.Length;

        int maxSubsets = (int)Math.Pow(2, numberOfElements) - 1; //opredelqme maximalniq broi na podmnojestvata

        for (int i = 1; i <= maxSubsets; i++)
        {
            subset.Clear();
            //subset = "";
            long checkingSum = 0;

            for (int j = 0; j < numberOfElements; j++)
            {
                int mask = 1 << j;
                int nAndMask = i & mask;
                int bit = nAndMask >> j;
                if (bit == 1)//ako 1viq bit na 4isloto e edinica, zna4i moje da u4astva v dadenoto podmnojestvo
                {
                    checkingSum = checkingSum + array[j];
                    subset.Add(array[j]);
                    //subset = subset + " " + array[j];
                }
            }
            if (checkingSum == neededSum && subset.Count == k)
            {
                Console.Write("Yes -> ");
                foreach (int number in subset)
                {
                    Console.Write(number + " ");
                }
                Console.WriteLine();
                isThereSubset = true;
            }
        }

        if (!isThereSubset)
        {
            Console.WriteLine("A subset with sum {0} and {1} elements does not exist", neededSum, k);
        }
    }
}

