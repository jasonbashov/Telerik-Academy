using System;
using System.Collections.Generic;

//Write a program that reads two integer numbers N and K and an array of N elements from the console. 
//Find in the array those K elements that have maximal sum.

class NArrayKSum
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

        Console.WriteLine("Enter K:");
        int k = int.Parse(Console.ReadLine());

        List<int> arrayList = new List<int>(); //syzdavam List, v koito shte kopiram array

        for (int i = 0; i < n; i++)
        {
            arrayList.Add(array[i]);
        }

        //sortiram list-a, v koito poslednite 4 elementa shte sa mi turseniqt array
        arrayList.Sort();

        //izpisvam vyvedeniq array
        Console.WriteLine("You have entered this array: ");
        foreach (var number in array)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();

        Console.WriteLine("The array with the maximum sum is: ");
        for (int i = arrayList.Count - k; i < arrayList.Count; i++)//pri arrayList.Count = 10 i K = 4 shte zapo4nem ot 6tiq element na list-a
        {
            Console.Write(arrayList[i] + " ");
        }
        Console.WriteLine(); 
    }
}