using System;

//Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.

class PrimeNum
{
    static void Main()
    {
        Console.WriteLine("Prime number");
        Console.WriteLine("_____________");
        Console.WriteLine("Enter a number:");
        int num = int.Parse(Console.ReadLine());

        if ((num > 1) & (num <= 100))
        {
            if (num == 2 || num == 3 || num == 5 || num == 7)
            {
                Console.WriteLine("The number {0} is prime", num);
            }
            else
            {
                if ((num % 2) == 0 || (num % 3) == 0 || (num % 4) == 0 || (num % 5) == 0 || (num % 6) == 0 || (num % 7) == 0 || (num % 8) == 0 || (num % 9) == 0 || (num % 10) == 0)
                {
                    Console.WriteLine("The number {0} is NOT prime", num);
                }
                else
                {
                    Console.WriteLine("The number {0} is prime", num);
                }
            }
        }
        else
        {
            Console.WriteLine("Number out of range");
        }
    }
}

