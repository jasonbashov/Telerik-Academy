using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.

class RectangularMatrix
{
    static void Main()
    {
        Console.WriteLine("Enter N >=3:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter M >=3:");
        int m = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, m];

        int tempSum = 0;
        int maxSum = 0;
        int rowPosition = 0;
        int colPosition = 0;

        if (n < 3 || m < 3)
        {
            Console.WriteLine("There is no square of 3x3 in this matrix");
        }
        else
        {
            //filling the matrix
            Console.WriteLine("Fill in the matrix:");
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.WriteLine("Enter element {0} {1} :",row,col);
                    matrix[row, col] = int.Parse(Console.ReadLine());
                }
            }

            //solution                        
            for (int row = 1; row < (matrix.GetLength(0) - 1); row++)
            {
                for (int col = 1; col < (matrix.GetLength(1) - 1); col++)
                {
                    tempSum = 0;
                    tempSum = matrix[row, col] + matrix[row - 1, col - 1] + matrix[row - 1, col] + matrix[row - 1, col + 1] + matrix[row, col - 1] + matrix[row, col + 1] + matrix[row + 1, col + 1] + matrix[row + 1, col]
                        + matrix[row + 1, col + 1]; //All the elements from the small matrix

                    if (tempSum > maxSum)
                    {
                        maxSum = tempSum;
                        rowPosition = row;
                        colPosition = col;
                    }
                }
            }

            Console.WriteLine("The square with the maximal sum is:");
            Console.WriteLine("{0} {1} {2}",matrix[rowPosition-1,colPosition-1],matrix[rowPosition-1,colPosition],matrix[rowPosition-1,colPosition+1]);
            Console.WriteLine("{0} {1} {2}", matrix[rowPosition, colPosition - 1], matrix[rowPosition, colPosition], matrix[rowPosition, colPosition + 1]);
            Console.WriteLine("{0} {1} {2}", matrix[rowPosition + 1, colPosition - 1], matrix[rowPosition + 1, colPosition], matrix[rowPosition + 1, colPosition + 1]);
            
        }
    }
}

