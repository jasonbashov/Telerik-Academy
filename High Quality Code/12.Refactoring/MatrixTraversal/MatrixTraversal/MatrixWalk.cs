using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixTraversal
{
    public class MatrixWalk
    { 
        public static void Main()
        {
            int n = ReadInputFromConsole();
            int[,] matrix = new int[n, n];
            int currentNumber = 1;
            int row = 0, col = 0;

            while (Matrix.FindEmptyCell(matrix, out row, out col))
            {
                int nextStepX = 1;
                int nextStepY = 1;
                while (true)
                {
                    matrix[row, col] = currentNumber;
                    currentNumber++;

                    if (Matrix.CheckNeighbourCellsForAvaibleMove(matrix, row, col))
                    {
                        while (row + nextStepX >= n || row + nextStepX < 0 || col + nextStepY >= n || col + nextStepY < 0 || matrix[row + nextStepX, col + nextStepY] != 0)
                        {
                            Matrix.ChangeDirections(ref nextStepX, ref nextStepY);
                        }
                    }
                    else
                    {
                        break;
                    }

                    row += nextStepX;
                    col += nextStepY;
                }
            }

            PrintMatrix(matrix);
        }

        public static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0,3}", matrix[i, j]);
                }

                Console.WriteLine();
            }
        }

        private static int ReadInputFromConsole()
        {
            int n;
            do
            {
                Console.WriteLine("Enter a positive number between 1-100:");
                n = int.Parse(Console.ReadLine());

            } while (n > 100 || n < 1);

            return n;
        }
/*
        public static void Main(string[] args)
        {
            int n = ReadInputFromConsole();
            int[,] matrix = new int[n, n];
            int counterSteps = 1;
            int currentRow = 0;
            int currentCol = 0;
            int nextStepX = 1;
            int nextStepY = 1;

            WalkInMatrixUntilThereIsNoAvaibleTileAround(matrix, n, ref nextStepX, ref nextStepY, ref currentRow, ref currentCol, ref counterSteps);

            Matrix.FindEmptyCell(matrix, out currentRow, out currentCol);

            //if n <= 3 there is no need to traverse the matrix again
            if (n > 3 && currentRow != 0 && currentCol != 0)
            {
                nextStepX = 1; 
                nextStepY = 1;

                WalkInMatrixUntilThereIsNoAvaibleTileAround(matrix, n, ref nextStepX, ref nextStepY, ref currentRow, ref currentCol, ref counterSteps);
            }

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write("{0,3}", matrix[row, col]);
                }

                Console.WriteLine();
            }
        }
 
        private static void WalkInMatrixUntilThereIsNoAvaibleTileAround(int[,] matrix, int matrixWidth, ref int nextStepX, ref int nextStepY, ref int currentRow, ref int currentCol, ref int counterSteps)
        {
            while (true)
            {
                matrix[currentRow, currentCol] = counterSteps;

                if (!Matrix.CheckNeighbourCellsForAvaibleMove(matrix, currentRow, currentCol))
                {
                    break; // if we can not walk any more in the matrix we break;
                }
                
                if (currentRow + nextStepX >= matrixWidth || currentRow + nextStepX < 0 ||
                    currentCol + nextStepY >= matrixWidth || currentCol + nextStepY < 0 ||
                    matrix[currentRow + nextStepX, currentCol + nextStepY] != 0)
                {
                    while ((currentRow + nextStepX >= matrixWidth || currentRow + nextStepX < 0 || currentCol + nextStepY >= matrixWidth || currentCol + nextStepY < 0 || matrix[currentRow + nextStepX, currentCol + nextStepY] != 0))
                    {
                        Matrix.ChangeDirections(ref nextStepX, ref nextStepY);
                    }
                }
                currentRow += nextStepX;
                currentCol += nextStepY;
                counterSteps++;
            }
        }*/
    }
}
