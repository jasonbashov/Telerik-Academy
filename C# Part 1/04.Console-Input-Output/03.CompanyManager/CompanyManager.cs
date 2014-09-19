using System;

//A company has name, address, phone number, fax number, web site and manager. 
//The manager has first name, last name, age and a phone number.
//Write a program that reads the information about a company and its manager and prints them on the console.

class CompanyManager
{
    static void Main()
    {
        string compName, address, webSite, firstName, lastName, phoneMan, phoneComp, faxNum;
        int age;
        Console.WriteLine("Company name:");
        compName = Console.ReadLine();
        Console.WriteLine("Company address:");
        address = Console.ReadLine();
        Console.WriteLine("Company web site:");
        webSite = Console.ReadLine();
        Console.WriteLine("Company phone number:");
        phoneComp = Console.ReadLine();
        Console.WriteLine("Company fax number:");
        faxNum = Console.ReadLine();
        Console.WriteLine("Manager's first name:");
        firstName = Console.ReadLine();
        Console.WriteLine("Manager's last name:");
        lastName = Console.ReadLine();
        Console.WriteLine("Manager's age:");
        age = int.Parse(Console.ReadLine());
        Console.WriteLine("Manager's phone:");
        phoneMan = Console.ReadLine();
        Console.WriteLine("____________________________________");
        Console.WriteLine("{0} company with adress: {1}",compName,address);
        Console.WriteLine("Web site: {0} Phone number: {1}; Fax number: {2}",webSite,phoneComp,faxNum);
        Console.WriteLine("____________________________________");
        Console.WriteLine("Manager info:");
        Console.WriteLine("Name: {0} {1}\n\rAge:{2} Phone number:{3}",firstName,lastName,age,phoneMan);
    }
}

