using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method that adds two polynomials. Represent them as arrays of their coefficients as in the example below:
//		x^2 + 5 = 1x^2 + 0x + 5 -> 5 0 1

class Coefficients
{
    static int[] AddingArraysSubMethod(int[] firstArray, int[] secondArray)
    {
        List<int> smallerNumberList = secondArray.OfType<int>().ToList();
        int howManyZeroes = firstArray.Length - secondArray.Length;
        while (howManyZeroes > 0)
        {
            smallerNumberList.Add(0);
            howManyZeroes--;
        }

        int[] smallerNumber = new int[smallerNumberList.Count];
        smallerNumber = smallerNumberList.ToArray();

        firstArray = firstArray.Zip(smallerNumber, (x, y) => x + y).ToArray();
        Array.Reverse(firstArray);
        return firstArray;
    }

    static int[] AddingPolunomial(int[] firstArray, int[] secondArray)
    {
        Array.Reverse(firstArray);
        Array.Reverse(secondArray);
        if (firstArray.Length > secondArray.Length)
        {
            firstArray = AddingArraysSubMethod(firstArray, secondArray);
            return firstArray;
        }
        else if (firstArray.Length < secondArray.Length)
        {
            secondArray = AddingArraysSubMethod(secondArray, firstArray);
            return secondArray;
        }
        else
        {
            firstArray = firstArray.Zip(secondArray, (x, y) => x + y).ToArray();//adds the two arrays
            Array.Reverse(firstArray);
            return firstArray;
        }
    }
    static void Main()
    {
        Console.WriteLine("Enter the first polynomial's lenght:");
        int firstLenght = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second polunomial's lenght:");
        int secondLenght = int.Parse(Console.ReadLine());

        int[] coefficientsFirst = new int[firstLenght];
        int[] coefficientsSecond = new int[secondLenght];
        int[] polynomialSum;

        char coefficientChar = 'a';

        Console.WriteLine("Enter first polynomial coefficients:");
        for (int i = 0; i < firstLenght; i++)
        {
            Console.WriteLine("Enter value for {0}:", coefficientChar);
            coefficientsFirst[i] = int.Parse(Console.ReadLine());
            coefficientChar++;
        }

        coefficientChar = 'a';
        Console.WriteLine("Enter second polynomial coefficients:");
        for (int i = 0; i < secondLenght; i++)
        {
            Console.WriteLine("Enter value for {0}:", coefficientChar);
            coefficientsSecond[i] = int.Parse(Console.ReadLine());
            coefficientChar++;
        }

        if (firstLenght > secondLenght)//inicializaciq na masiva na sumata 
        {
            polynomialSum = new int[firstLenght];
        }
        else
        {
            polynomialSum = new int[secondLenght];
        }

        polynomialSum = AddingPolunomial(coefficientsFirst, coefficientsSecond);

        int counter = polynomialSum.Length;

        foreach (int num in polynomialSum)
        {
            if (counter > 1)
            {
                Console.Write("{0}x^{1} + ", num, counter - 1);
                counter--;
            }
            else
            {
                Console.WriteLine(num);
            }
        }
    }
}

