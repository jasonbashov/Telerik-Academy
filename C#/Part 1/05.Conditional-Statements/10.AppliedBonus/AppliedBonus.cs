using System;

//Write a program that applies bonus scores to given scores in the range [1..9]. 
//The program reads a digit as an input. If the digit is between 1 and 3, the program multiplies it by 10;
//if it is between 4 and 6, multiplies it by 100; if it is between 7 and 9, multiplies it by 1000. 
//If it is zero or if the value is not a digit, the program must report an error.
//	Use a switch statement and at the end print the calculated new value in the console.

class AppliedBonus
{
    static void Main()
    {
        Console.WriteLine("Enter a digit from 1-9: ");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
            case 2:
            case 3:
                choice *= 10;
                Console.WriteLine("Your score is {0}", choice);
                break;
            case 4:
            case 5:
            case 6:
                choice *= 100;
                Console.WriteLine("Your score is {0}", choice);
                break;
            case 7:
            case 8:
            case 9:
                choice *= 1000;
                Console.WriteLine("Your score is {0}", choice);
                break;
            default: Console.WriteLine("Error");
                break;
        }
    }
}

