using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

//Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] 
//contains a digit; the last digit is kept in arr[0]). Each of the numbers that will be added could have up to 10 000 digits.

class IntAdd
{
    static BigInteger[] firstArray;
    static BigInteger[] secondArray;

    static BigInteger[] NumbersIn(BigInteger value)
    {
        var numbers = new Stack<BigInteger>();

        for (; value > 0; value /= 10)
        {
            numbers.Push(value % 10);
        }

        return numbers.ToArray();
    }

    static BigInteger[] AddingArraysSubMethod(BigInteger[] firstArray, BigInteger[] secondArray)
    {
        List<BigInteger> smallerNumberList = secondArray.OfType<BigInteger>().ToList();
        BigInteger howManyZeroes = firstArray.Length - secondArray.Length;
        while (howManyZeroes > 0)
        {
            smallerNumberList.Add(0);
            howManyZeroes--;
        }

        BigInteger[] smallerNumber = new BigInteger[smallerNumberList.Count];
        smallerNumber = smallerNumberList.ToArray();

        firstArray = firstArray.Zip(smallerNumber, (x, y) => x + y).ToArray();
        Array.Reverse(firstArray);
        return firstArray;
    }

    static BigInteger[] AddingArrays(BigInteger[] firstArray, BigInteger[] secondArray)
    {
        Array.Reverse(firstArray);
        Array.Reverse(secondArray);
        if (firstArray.Length > secondArray.Length)
        {
            firstArray = AddingArraysSubMethod(firstArray, secondArray);
            firstArray = FinalSumRemodeling(firstArray);
            return firstArray;
        }
        else if (firstArray.Length < secondArray.Length)
        {
            secondArray = AddingArraysSubMethod(secondArray, firstArray);
            secondArray = FinalSumRemodeling(secondArray);
            return secondArray;
        }
        else
        {
            firstArray = firstArray.Zip(secondArray, (x, y) => x + y).ToArray();//adds the two arrays
            Array.Reverse(firstArray);
            firstArray = FinalSumRemodeling(firstArray);
            return firstArray;
        }
    }

    static BigInteger[] FinalSumRemodeling(BigInteger[] intList)//s tozi metod shte koregiram elementite na finalnata suma(10;11;12 -> 1122)
    {
        for (int i = intList.Length-1; i > 0; i--)
        {
            if (intList[i] >= 10)
            {
                intList[i - 1]++;
                intList[i] -= 10;
            }
        }
        return intList;
    }
        
    
    static void Main()
    {
        Console.WriteLine("Enter the first positive number: ");
        BigInteger first = BigInteger.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second positive number: ");
        BigInteger second = BigInteger.Parse(Console.ReadLine());

        BigInteger temp = first;
        //geting the arraysToBeMade length
        int arrayLength = 0;
        for (; temp > 0; temp /= 10)
        {
            arrayLength++;
        }


        firstArray = new BigInteger[arrayLength];
        firstArray = NumbersIn(first);

        arrayLength = 0;
        temp = second;
        for (; temp > 0; temp /= 10)
        {
            arrayLength++;
        }

        secondArray = new BigInteger[arrayLength];
        secondArray = NumbersIn(second);

        List<BigInteger> sumList = AddingArrays(firstArray, secondArray).OfType<BigInteger>().ToList();
        foreach (int num in sumList)
        {
            Console.Write(num);
        }
        Console.WriteLine();
    }
}

