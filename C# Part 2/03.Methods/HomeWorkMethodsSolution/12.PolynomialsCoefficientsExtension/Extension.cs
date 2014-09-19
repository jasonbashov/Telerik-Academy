using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Extend the program to support also subtraction and multiplication of polynomials.

class Extension
{
    static int[] SubtractArraysSubMethod(int[] firstArray, int[] secondArray)
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

        firstArray = firstArray.Zip(smallerNumber, (x, y) => x - y).ToArray();
        Array.Reverse(firstArray);
        return firstArray;
    }

    static int[] CheckForZeroes(int[] arrayToCheck)
    {
        for (int i = 0; i < arrayToCheck.Length; i++)
        {
            if (arrayToCheck[i] == 0)
            {
                arrayToCheck[i] = 1;
            }
        }
        return arrayToCheck;
    }

    static int[] Multiplication(int[] firstArray, int[] secondArray)
    {
        firstArray = CheckForZeroes(firstArray);
        secondArray = CheckForZeroes(secondArray);

        List<int> smallerNumberList = secondArray.OfType<int>().ToList();

        int howManyZeroes = firstArray.Length - secondArray.Length;
        while (howManyZeroes > 0)
        {
            smallerNumberList.Add(1); //filling with 1 to avoid reset (0*x=0)
            howManyZeroes--;
        }

        int[] smallerNumber = new int[smallerNumberList.Count];
        smallerNumber = smallerNumberList.ToArray();

        firstArray = firstArray.Zip(smallerNumber, (x, y) => x * y).ToArray();
        Array.Reverse(firstArray);
        return firstArray;

    }

    static int[] SubtractOrMultiply(int[] firstArray, int[] secondArray)
    {
        Array.Reverse(firstArray);
        Array.Reverse(secondArray);
        if (firstArray.Length > secondArray.Length)
        {
            firstArray = SubtractArraysSubMethod(firstArray, secondArray);
            return firstArray;
        }
        else if (firstArray.Length < secondArray.Length)
        {
            secondArray = SubtractArraysSubMethod(secondArray, firstArray);
            return secondArray;
        }
        else
        {
            firstArray = firstArray.Zip(secondArray, (x, y) => x - y).ToArray();
            Array.Reverse(firstArray);
            return firstArray;
        }
    }

    static void MultiplyPolinomials(int[] firstPolinomial, int[] secondPolinomial, int[] result)
    {
        //declare zeros at result polinom
        for (int i = 0; i < result.Length; i++)
        {
            result[i] = 0;
        }

        for (int i = 0; i < firstPolinomial.Length; i++)
        {
            for (int j = 0; j < secondPolinomial.Length; j++)
            {
                int position = i + j;
                result[position] += (firstPolinomial[i] * secondPolinomial[j]);
            }
        }
        //return result;
    }

    static void PrintArray(int[] polinomial)
    {
        for (int i = polinomial.Length - 1; i >= 0; i--)
        {
            if (polinomial[i] != 0 && i != 0)
            {
                if (polinomial[i - 1] >= 0)
                {
                    Console.Write("{1}x^{0} +", i, polinomial[i]);
                }
                else
                {
                    Console.Write("{1}x^{0} ", i, polinomial[i]);
                }
            }
            else if (i == 0)
            {
                Console.Write("{0}", polinomial[i]);
            }
        }

        Console.WriteLine();
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

        //polynomialSum = SubtractOrMultiply(coefficientsFirst, coefficientsSecond, 1);

        int choice = 0;

        Console.WriteLine("Please choose:");
        Console.WriteLine("1. Subtraction");
        Console.WriteLine("2. Multiplication");
        choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                polynomialSum = SubtractOrMultiply(coefficientsFirst, coefficientsSecond);
                PrintArray(polynomialSum);
                break;
            case 2:
                int[] multiply = new int[coefficientsFirst.Length + coefficientsSecond.Length];
                MultiplyPolinomials(coefficientsFirst, coefficientsSecond, multiply);
                PrintArray(multiply);
                break;
            default: Console.WriteLine("Your choice is wrong!"); break;
        }




    }
}

