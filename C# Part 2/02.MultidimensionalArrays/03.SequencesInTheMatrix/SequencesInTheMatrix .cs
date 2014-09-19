using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several 
//neighbor elements located on the same line, column or diagonal. Write a program that finds the longest 
//sequence of equal strings in the matrix. Example:

class SequencesInTheMatrix
{
    static string[,] matrix ;
    /*static string[,] matrix =
    {
    {"aa","s","s"},
    {"aa","ss","dd"},
    {"aa","ss","dd"},
    {"aa","a","dd"},
    };*/

    static List<string> sequence; //the temporary sequence
    static List<string> maxSeq; //the maximal sequence

    static void FillTheMatrix(string[,] matrix)
    {
        //filling the matrix
        Console.WriteLine("Fill in the matrix:");
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.WriteLine("Enter element {0} {1} :", row, col);
                matrix[row, col] = Console.ReadLine();
            }
        }
    }

    static void FindPath(int row, int col, string symbol)
    {
        if ((col < 0) || (row < 0) ||
        (col >= matrix.GetLength(1)) || (row >= matrix.GetLength(0)))
        {
            // We are out of the matrix
            return;
        }
        if (matrix[row, col] != symbol)
        {
            // The current cell is not free
            return;
        }
        if (matrix[row,col] == "visited")
        {
            return;
        }
        // Mark the current cell as visited
        matrix[row, col] = "visited";
        sequence.Add(symbol);
        // Invoke recursion to explore all possible directions
        FindPath(row, col - 1, symbol); // left
        FindPath(row - 1, col, symbol); // up
        FindPath(row, col + 1, symbol); // right
        FindPath(row + 1, col, symbol); // down
        FindPath(row - 1, col - 1, symbol);// upperleft
        FindPath(row - 1, col + 1, symbol);//upperright
        FindPath(row + 1, col - 1, symbol);//lowerleft
        FindPath(row + 1, col + 1, symbol);//lowerright
    }

    static void Main()
    {
        Console.WriteLine("Enter N:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter M:");
        int m = int.Parse(Console.ReadLine());

        matrix = new string[n, m];
        sequence = new List<string>();
        maxSeq = new List<string>();
        

        FillTheMatrix(matrix);
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                string symbolToSearch = matrix[row, col];
                FindPath(row, col, symbolToSearch);
                if (sequence.Count > maxSeq.Count)
                {
                    maxSeq.Clear();
                    foreach (string sym in sequence)
                    {
                        maxSeq.Add(sym);
                    }
                }
                sequence.Clear();
            }
        }

        foreach (string sym in maxSeq)
        {
            Console.Write(sym + ";");
        }
        Console.WriteLine();

    }
}

