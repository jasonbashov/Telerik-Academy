using System;

//Write a program that, depending on the user's choice inputs int, double or string variable. 
//If the variable is integer or double, increases it with 1. If the variable is string, appends "*" at its end.
//The program must show the value of that variable as a console output. Use switch statement.

class UserChoice
{
    static void Main()
    {
        Console.WriteLine("Enter user's choice: ");
        Console.WriteLine("1 for integer");
        Console.WriteLine("2 for double");
        Console.WriteLine("3 for string");
        byte choice = byte.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("Enter an integer: ");
                int i = int.Parse(Console.ReadLine());
                i++;
                Console.WriteLine(i);break;
            case 2:
                Console.WriteLine("Enter a double: ");
                double d = double.Parse(Console.ReadLine());
                d++;
                Console.WriteLine(d); break;
            case 3:
                Console.WriteLine("Enter a string: ");
                string str = Console.ReadLine();
                str += '*';
                Console.WriteLine(str); break;
            default:
                Console.WriteLine("Invalid input.");
                break;
        }

    }
}

