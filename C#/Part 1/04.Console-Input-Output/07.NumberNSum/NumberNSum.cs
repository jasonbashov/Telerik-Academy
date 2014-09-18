using System;

//Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum. 

    class NumberNSum
    {
        static void Main()
        {
            Console.WriteLine("How many numbers you wish to sum:");
            int n = int.Parse(Console.ReadLine());

            double sum = 0;

            for (int i = 0; i < n ; i++)
            {
                Console.WriteLine("Enter a number:");
                double temp = double.Parse(Console.ReadLine());

                sum += temp;
            }
            Console.WriteLine("The numbers sum is: "+sum);
        }
    }

