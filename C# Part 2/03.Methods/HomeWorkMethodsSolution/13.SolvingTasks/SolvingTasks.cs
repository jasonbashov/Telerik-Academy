using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that can solve these tasks:
//  -Reverses the digits of a number
//  -Calculates the average of a sequence of integers
//  -Solves a linear equation a * x + b = 0
//Create appropriate methods. Provide a simple text-based menu for the user to choose which task to solve.
//Validate the input data:
//  -The decimal number should be non-negative
//  -The sequence should not be empty
//  -"a" should not be equal to 0

class SolvingTasks
{
    static int[] seq;
    static int Menu()
    {
        Console.WriteLine();
        Console.WriteLine("********MENU********");
        Console.WriteLine("1. Reverses the digits of a number");
        Console.WriteLine("2. Calculates the average of a sequence of integers");
        Console.WriteLine("3. Solves a linear equation [a * x + b = 0]");
        Console.WriteLine("4. Exit");
        Console.WriteLine("********************");
        Console.WriteLine("Make your choice: ");
        int choice = int.Parse(Console.ReadLine());

        return choice;
    }

    static void FillTheSequence()
    {
        int seqLenght = 0;
        do
        {
            Console.WriteLine("Enter sequence's lenght > 0: ");
            seqLenght = int.Parse(Console.ReadLine());
        } while (seqLenght < 0);

        seq = new int[seqLenght];

        Console.WriteLine("Fill the array:");
        for (int i = 0; i < seq.Length; i++)
        {
            Console.WriteLine("Enter index {0} value:", i);
            seq[i] = int.Parse(Console.ReadLine());
        }

    }

    static void Reverse()
    {
        decimal numberToReverse = -1;
        do
        {
            Console.WriteLine("Enter a positive number: ");
            numberToReverse = decimal.Parse(Console.ReadLine());
        } while (numberToReverse < 0);

        string temp = numberToReverse.ToString();
        temp = ReverseDigits(temp);
        numberToReverse = decimal.Parse(temp);
        Console.WriteLine("The reversed number is: " + temp);
    }

    static string ReverseDigits(string decimalNumber)
    {
        char[] cArray = decimalNumber.ToCharArray();
        string reverse = String.Empty;
        for (int i = cArray.Length - 1; i > -1; i--)
        {
            reverse += cArray[i];
        }
        return reverse;
    }

    static void Average()
    {
        float sum = 0;

        FillTheSequence();

        foreach (int num in seq)
        {
            sum += num;
        }

        Console.WriteLine("The average is: {0}", (sum / seq.Length));
    }

    static void Equation()
    {
        float a = 0f;

        do
        {
            Console.WriteLine("Enter value for 'a': ");
            a = float.Parse(Console.ReadLine());
        } while (a == 0);
        Console.WriteLine("Enter value for 'b':");
        float b = float.Parse(Console.ReadLine());

        float x = (-b) / a;
        Console.WriteLine("The root 'x' is: " + x);
    }

    static void Main()
    {
        int choice = 0;
        do
        {
            choice = Menu();
            switch (choice)
            {
                case 1:
                    Reverse();
                    break;
                case 2:
                    Average();
                    break;
                case 3:
                    Equation();
                    break;
                default: break;
            }
        }
        while (choice != 4);
    }
}

