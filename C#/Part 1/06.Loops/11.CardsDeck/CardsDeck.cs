using System;

//Write a program that prints all possible cards from a standard deck of 52 cards (without jokers). 
//The cards should be printed with their English names. Use nested for loops and switch-case.

class CardsDeck
{
    static void Main()
    {
        for (int i = 1; i <= 13; i++)
        {
            for (int j = 1; j <= 4; j++)
            {
                switch (i)
                {
                    case 1: Console.Write("Ace of "); break;
                    case 2: Console.Write("Two of "); break;
                    case 3: Console.Write("Three of "); break;
                    case 4: Console.Write("Four of "); break;
                    case 5: Console.Write("Five of "); break;
                    case 6: Console.Write("Six of "); break;
                    case 7: Console.Write("Seven of "); break;
                    case 8: Console.Write("Eight of "); break;
                    case 9: Console.Write("Nine of "); break;
                    case 10: Console.Write("Ten of "); break;
                    case 11: Console.Write("Jack of "); break;
                    case 12: Console.Write("Queen of "); break;
                    case 13: Console.Write("King of "); break;
                    default: break;
                }
                switch (j)
                {
                    case 1: Console.WriteLine("Clubs"); break;
                    case 2: Console.WriteLine("Diamons"); break;
                    case 3: Console.WriteLine("Hearts"); break;
                    case 4: Console.WriteLine("Spades"); break;
                    default: break;
                }
            }
            
            /*switch (i)
            {
                case 1: Console.WriteLine("Ace of Diamonds"); break;
                case 2: Console.WriteLine("Two of Diamonds"); break;
                case 3: Console.WriteLine("Three of Diamonds"); break;
                case 4: Console.WriteLine("Four of Diamonds"); break;
                case 5: Console.WriteLine("Five of Diamonds"); break;
                case 6: Console.WriteLine("Six of Diamonds"); break;
                case 7: Console.WriteLine("Seven of Diamonds"); break;
                case 8: Console.WriteLine("Eight of Diamonds"); break;
                case 9: Console.WriteLine("Nine of Diamonds"); break;
                case 10: Console.WriteLine("Ten of Diamonds"); break;
                case 11: Console.WriteLine("Jack of Diamonds"); break;
                case 12: Console.WriteLine("Queen of Diamonds"); break;
                case 13: Console.WriteLine("King of Diamonds"); break;
                default: break;
            } switch (i)
            {
                case 1: Console.WriteLine("Ace of Hearts"); break;
                case 2: Console.WriteLine("Two of Hearts"); break;
                case 3: Console.WriteLine("Three of Hearts"); break;
                case 4: Console.WriteLine("Four of Hearts"); break;
                case 5: Console.WriteLine("Five of Hearts"); break;
                case 6: Console.WriteLine("Six of Hearts"); break;
                case 7: Console.WriteLine("Seven of Hearts"); break;
                case 8: Console.WriteLine("Eight of Hearts"); break;
                case 9: Console.WriteLine("Nine of Hearts"); break;
                case 10: Console.WriteLine("Ten of Hearts"); break;
                case 11: Console.WriteLine("Jack of Hearts"); break;
                case 12: Console.WriteLine("Queen of Hearts"); break;
                case 13: Console.WriteLine("King of Hearts"); break;
                default: break;
            } switch (i)
            {
                case 1: Console.WriteLine("Ace of Spades"); break;
                case 2: Console.WriteLine("Two of Spades"); break;
                case 3: Console.WriteLine("Three of Spades"); break;
                case 4: Console.WriteLine("Four of Spades"); break;
                case 5: Console.WriteLine("Five of Spades"); break;
                case 6: Console.WriteLine("Six of Spades"); break;
                case 7: Console.WriteLine("Seven of Spades"); break;
                case 8: Console.WriteLine("Eight of Spades"); break;
                case 9: Console.WriteLine("Nine of Spades"); break;
                case 10: Console.WriteLine("Ten of Spades"); break;
                case 11: Console.WriteLine("Jack of Spades"); break;
                case 12: Console.WriteLine("Queen of Spades"); break;
                case 13: Console.WriteLine("King of Spades"); break;
                default: break;
            }*/

        }
    }
}

