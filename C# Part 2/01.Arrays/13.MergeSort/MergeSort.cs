using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//* Write a program that sorts an array of integers using the merge sort algorithm (find it in Wikipedia).
class MergeSort
{
    //merges two arrays
    static int[] MergeArrays(int[] left, int[] right)
    {
        int[] result = new int[left.Length + right.Length];
 
        int leftIncrease = 0;
        int rightIncrease = 0;
 
        for (int i = 0; i < result.Length; i++)
        {
            if (rightIncrease == right.Length || ((leftIncrease < left.Length) && (left[leftIncrease] <= right[rightIncrease])))
            {
                result[i] = left[leftIncrease];
                leftIncrease++;
            }
            else if (leftIncrease == left.Length || ((rightIncrease < right.Length) && (right[rightIncrease] <= left[leftIncrease])))
            {
                result[i] = right[rightIncrease];
                rightIncrease++;
            }
        }
 
        return result;
    }
 
    //recursevily merges two arrays
    static int[] MergeSorting(int[] array)
    {
        if (array.Length <= 1)
        {
            return array;
        }
 
        int middle = array.Length / 2;
        int[] leftArray = new int[middle];
        int[] rightArray = new int[array.Length - middle];
 
        for (int i = 0; i < middle; i++)
        {
            leftArray[i] = array[i];
        }
 
        for (int i = middle, j = 0; i < array.Length; i++, j++)
        {
            rightArray[j] = array[i];
        }
 
        leftArray = MergeSorting(leftArray);
        rightArray = MergeSorting(rightArray);
 
        return MergeArrays(leftArray, rightArray);
    }
 
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
 
        //int[] array = { 1, 5, 7, 8, 9, 3, 5, 6, 7 };

        int[] sortedArray = MergeSorting(array);

        foreach (int number in sortedArray)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }
}
//Neuspeshni opiti za reshenie... bez rekursiq

        /*Console.WriteLine("Enter the array's length N:");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        Console.WriteLine("Fill the array:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine("Enter index {0} value:", i);
            array[i] = int.Parse(Console.ReadLine());
        }*/





        
        //List<int> intList = new List<int>();
        //List<int> mergedList = new List<int>();
        //List<int> leftList = new List<int>();
        //List<int> rightList = new List<int>();
        //int currPosition = 0;
        //
        //int step = 1;
        //
        //for (int i = 0; i < array.Length; i+=2)
        //{
        //    if (array[i] > array[i + step])
        //    {
        //        intList.Add(array[i + step]);
        //        intList.Add(array[i]);
        //    }
        //    else
        //    {
        //        intList.Add(array[i]);
        //        intList.Add(array[i + step]);
        //    }
        //}
        //
        //step++;
        //
        //foreach (int num in intList)
        //{
        //    Console.Write(num + " ");
        //}
        //Console.WriteLine();
        //
        //while (true)
        //{
        //    leftList.Clear();
        //    rightList.Clear();
        //
        //    for (int i =0 /*currPosition*/; i < step; i++)//razdelqme golemiq list na malki podlisti kato zapo4vame ot step 2/4/8
        //    {
        //        leftList.Add(intList[i]);
        //        rightList.Add(intList[i + step]);
        //    }
        //
        //    step *= 2;
        //
        //    for (int i = 0; i < leftList.Count; i++)
        //    {
        //        bool isSomethingAdd = false;
        //
        //        for (int j = 0; j < rightList.Count; j++)
        //        {
        //
        //            if (leftList[i] < rightList[j])
        //            {
        //                mergedList.Add(leftList[i]);
        //                //intList[curPosition] = leftList[i];
        //                //curPosition++;
        //                //isSomethingAdd = true;
        //                break;
        //            }
        //            else if (leftList[i] > rightList[j])
        //            {
        //                mergedList.Add(rightList[j]);
        //                isSomethingAdd = true;
        //                //mergedList.Add(leftList[i]);
        //                //intList[curPosition] = rightList[j];
        //                // curPosition++;
        //                //break;
        //            }
        //        }
        //        if (isSomethingAdd)
        //        {
        //            for (int j = i; j < rightList.Count; j++)
        //            {
        //                mergedList.Add(leftList[j]);
        //            }
        //            isSomethingAdd = false;
        //            break;
        //        }
        //        if (mergedList.Count == leftList.Count)
        //        {
        //            for (int j = 0; j < rightList.Count; j++)
        //            {
        //                mergedList.Add(rightList[j]);
        //            }
        //        }
        //    }
        //
        //    //zamestvane na stoinostite ot mergelist v intList
        //
        //    for (int i = 0; i < mergedList.Count; i++)
        //    {
        //        intList[i] = mergedList[i];
        //        currPosition++;
        //    }
        //    mergedList.Clear();
        //
        //    int middle = intList.Count / 2;
        //
        //}
        //    /*if (mergedList.Count == leftList.Count)
        //    {
        //        for (int j = 0; j < rightList.Count; j++)
        //        {
        //            mergedList.Add(rightList[j]);
        //        }
        //    }
        //
        //    foreach (int num in intList)
        //    {
        //        Console.Write(num + " ");
        //    }
        //    Console.WriteLine();
        //
        //    */
