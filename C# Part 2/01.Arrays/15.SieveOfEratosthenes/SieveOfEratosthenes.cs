using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that finds all prime numbers in the range [1...10 000 000].
//Use the sieve of Eratosthenes algorithm (find it in Wikipedia).

class SieveOfEratosthenes
{
    static void Main()
    {
        bool[] numbers = new bool[10000000];


        int max = (int)Math.Sqrt(numbers.Length);

        for (int i = 2; i < max; i++)
        {
            if (numbers[i] == false)
            {
                for (int j = i * i; j < numbers.Length; j = j + i)
                {
                    numbers[j] = true;
                }
            }
        }

        for (int i = 2; i < numbers.Length; i++)
        {
            if (numbers[i] == false)
            {
                Console.Write(i + " ");
            }
        }
        Console.WriteLine();

        /*Вариант 2: И двата варианта работят коректно, разликата е в скоростта*/

        /*List<int> intList = new List<int>();
        
        for (int i = 2; i <= 100; i++)
        {
            intList.Add(i);
        }
        
        Console.WriteLine(intList.Count);
        
        int max = (int)Math.Sqrt(intList.Count);
        
        for (int i = 2; i < max; i++)
        {
            Console.WriteLine(intList.Count);
            for (int j = i; j < intList.Count; j++)//(int j = i * i; j < intList.Count; j++)
            {
                intList.Remove(j*i);
            }
        }
        
        Console.WriteLine(intList.Count);
        
        
        
        foreach (int num in intList)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();*/
    }
}

