using System;

//A bank account has a holder name (first name, middle name and last name),
//available amount of money (balance), bank name, IBAN, BIC code and 3 credit card numbers associated with the account. 
//Declare the variables needed to keep the information for a single bank account using the appropriate data types
//and descriptive names.

class BankAcc
{
    static void Main()
    {
        string firstName, middleName, lastName, bankName, iBAN, bIC, card1, card2, card3;
        double balance;

        firstName = "Jason";
        middleName = "Machete";
        lastName = "Voorhees";
        bankName = "DSK";
        iBAN = "BGXX XXXX XXXX XXXX XXXX XX";
        bIC = "BG DSK XX";
        card1 = "XXXX XXXX XXXX XXX1";
        card2 = "XXXX XXXX XXXX XXX2";
        card3 = "XXXX XXXX XXXX XXX3";
        balance = 1455.60d;

        Console.Title = bankName;
        Console.WriteLine("Bank account: {0} {1} {2}", firstName, middleName, lastName);
        Console.WriteLine("IBAN: {0}; BIC: {1}", iBAN, bIC);
        Console.WriteLine("Balance: {0} Lv.",balance);
        Console.WriteLine("Credit card information: "+card1+" "+card2+" "+card3);
    }
}

