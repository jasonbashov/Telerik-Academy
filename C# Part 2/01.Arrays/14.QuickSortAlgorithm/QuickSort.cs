using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that sorts an array of strings using the quick sort algorithm (find it in Wikipedia).

class QuickSort
{
    static void Main(string[] args)
    {
        //int[] array = { 3,15, 8,8, 5,11, 7, 2, 1, 9, 6,10 };

        Console.WriteLine("Enter the array's length N:");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        Console.WriteLine("Fill the array:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine("Enter index {0} value:", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        
        int temp = 0;

        for (int i = 0; i < array.Length; i++)
        {
            foreach (int item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            for (int j = i; j < array.Length; j++)//tozi cikyl tursi za po-golemite 4isla ot segashnoto
            {
                if (array[j] > array[i])
                {
                    for (int jj = array.Length-1; jj > j; jj--)//s tozi cikyl se tyrsi ot kraq na masiva kym nachaloto za po-malko 4islo
                    {
                        if (array[jj] < array[i])
                        {
                           temp = array[jj];
                           array[jj] = array[j];
                           array[j] = temp;
                           break;
                        }
                    }
                }
                if (array[j] < array[i])
                {
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
        }





       
        foreach (int item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}

