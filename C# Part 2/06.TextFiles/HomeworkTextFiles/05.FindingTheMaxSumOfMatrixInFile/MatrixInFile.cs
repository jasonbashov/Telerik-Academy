using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//Write a program that reads a text file containing a square matrix of numbers and finds in the matrix an area of size 2 x 2 with a
//maximal sum of its elements. The first line in the input file contains the size of matrix N. 
//Each of the next N lines contain N numbers separated by space. The output should be a single number in a separate text file. Example:
//4
//2 3 3 4
//0 2 3 4 ------>	17
//3 7 1 2
//4 3 3 2

class MatrixInFile
{
    static void Main()
    {
        StreamReader reader = new StreamReader("matrix.txt");

        using (reader)
        {
            string line = reader.ReadLine();
            int n = int.Parse(line);

            int[,] matrix = new int[n, n];
            int row = 0;
            int col = 0;
            while (line != null)
            {
                line = reader.ReadLine();
                if (line == null)
                {
                    break;
                }
                
                int i = 0;
                string[] numbers = line.Split(' ');
                
                foreach (string number in numbers)
                {
                    matrix[row, i] = int.Parse(number);
                    i++;
                }
                row++;
            }

            int maxSum = 0;
            int tempSum = 0;

            for (int r0w = 1; r0w < matrix.GetLength(0) ; r0w++)
            {
                for (int c0l = 1; c0l < matrix.GetLength(1) ; c0l++)
                {
                    tempSum = matrix[r0w, c0l] + matrix[r0w - 1, c0l - 1] + matrix[r0w - 1, c0l] + matrix[r0w, c0l - 1];
                    if (tempSum > maxSum)
                    {
                        maxSum = tempSum;
                    }
                }
            }
            Console.WriteLine(maxSum);
        }
    }
}

