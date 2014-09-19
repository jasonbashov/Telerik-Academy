using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that generates and prints to the console 10 random values in the range [100, 200].

class RandomValues
{
    static void Main()
    {
        Random rand = new Random();

        for (int number = 1; number <= 10; number++)
        {
            int randomNumber = rand.Next(149) + 1;

            if (randomNumber <= 200)
            {
                if (randomNumber >= 100)
                {
                    Console.Write("{0} ", randomNumber);
                }
                else
                {
                    number--;
                }
                
            }
            else
            {
                number--;
            }
            
        }
        Console.WriteLine();

    }
}

