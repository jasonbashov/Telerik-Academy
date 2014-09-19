using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method that asks the user for his name and prints “Hello, <name>” (for example, “Hello, Peter!”).
//Write a program to test this method.

class Program
{
    static void Hello(string name)
    {
        Console.WriteLine("Hello, {0}!", name);
    }

    static void Main()
    {
        Console.WriteLine("Enter your name:");
        string usersName = Console.ReadLine();
        Hello(usersName);
    }
}

