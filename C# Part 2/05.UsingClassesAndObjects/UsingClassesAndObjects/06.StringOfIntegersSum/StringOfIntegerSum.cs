using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//You are given a sequence of positive integer values written into a string, separated by spaces. 
//Write a function that reads these values from given string and calculates their sum. Example:
//	string = "43 68 9 23 318" -> result = 461


class StringOfIntegerSum
{
    static int StringToIntegers(string stringOfNumbers)
    {
        char[] charSeparators = new char[] { ' ', ',', '-', '/',';' };

        string[] splittedArray = stringOfNumbers.Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);

        int[] numbers = new int[splittedArray.Length];
        int i = 0;
        foreach (var number in splittedArray)
        {
            numbers[i] = int.Parse(number);
            i++;
        }

        int sum = FindSum(numbers);

        return sum;
    }

    static int FindSum(int[] arrayOfNumbers)
    {
        int totalSum = 0;
        int i = 0;

        foreach (int number in arrayOfNumbers)
        {
            totalSum += arrayOfNumbers[i];
            i++;
        }

        return totalSum;
    }

    static void Main()
    {
        Console.WriteLine("Enter your sting of numbers:");
        string numbersString = Console.ReadLine();

        Console.WriteLine("The total sum is: " + StringToIntegers(numbersString));
    }
}

