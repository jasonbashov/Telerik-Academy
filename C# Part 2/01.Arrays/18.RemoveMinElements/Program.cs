using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//* Write a program that reads an array of integers and removes from it a minimal number of elements in such way that the 
//remaining array is sorted in increasing order. Print the remaining sorted array. Example:
//	{6, 1, 4, 3, 0, 3, 6, 4, 5} -> {1, 3, 3, 4, 5}

//resheniqto e bazirano na predhodnite 2 zadachi, no s leki promeni v implementaciqta

class Program
{
    static bool IsSorted(List<int> list)
    {
        bool isSorted = true;

        for (int i = 0; i < list.Count - 1; i++)
        {
            if (list[i] > list[i + 1])
            {
                isSorted = false;
            }
        }

        return isSorted;
    }

    static void Main()
    {
        //int[] array = { 6, 1, 4, 3, 0, 3, 6, 4, 5,1,6,99,2,7,8 };

        Console.WriteLine("Enter the array's length N:");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        Console.WriteLine("Fill the array:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine("Enter index {0} value:", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        List<int> tempList = new List<int>();
        List<int> neededList = new List<int>();

        //string subset = "";
        bool isSubsetSorted = false;
        

        int numberOfElements = array.Length;

        int maxSubsets = (int)Math.Pow(2, numberOfElements) - 1; //opredelqme maximalniq broi na podmnojestvata

        for (int i = 1; i <= maxSubsets; i++)
        {
            tempList.Clear();
            //long checkingSum = 0;
            //int countElements = 0;

            for (int j = 0; j < numberOfElements; j++)
            {
                int mask = 1 << j;
                int nAndMask = i & mask;
                int bit = nAndMask >> j;
                if (bit == 1)//ako 1viq bit na 4isloto e edinica, zna4i moje da u4astva v dadenoto podmnojestvo
                {
                    //checkingSum = checkingSum + array[j];
                    //subset = subset + " " + array[j];
                    //countElements++;
                    tempList.Add(array[j]);
                }
            }

            isSubsetSorted = IsSorted(tempList);

            if (isSubsetSorted && (neededList.Count < tempList.Count))//ako temp list-a e sortiran i temp lista e po-dylyg ot neededList -> temp list e nashiq list
            {
                neededList.Clear();
                foreach (int number in tempList)
                {
                    neededList.Add(number);
                }
                //Console.WriteLine("Yes ->" + subset);
                //isSubsetSorted = true;
            }
        }

        foreach (int number in neededList)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }
}

