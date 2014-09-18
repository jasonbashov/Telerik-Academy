using System;

//Write a program to calculate the sum (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...


class TheSumAccurate
{
    static void Main()
    {
        double sum = 1d;
        double positive = 0d;
        double negative = 0d;

        for (int i = 2; i < 1000; i++)// i < 1000 so we achieve the accuracy of 0.001
        {
            double temp = sum;
            if (i % 2 == 0)
            {
                positive = 1d / (double)i;
                temp += positive;
            }
            else
            {
                negative = (-1d / (double)i);
                temp += negative;
            }
            sum = temp;
        }
        Console.WriteLine("The sum is: {0:0.000}", sum);
    }
}

