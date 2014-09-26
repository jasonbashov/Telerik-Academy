using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.DefiningMatrixGeneric
{
    class TestingClass
    {
        static void Main()
        {
            Matrix<int> matrix = new Matrix<int>(10,10);

            /*for (int rows = 0; rows < 10; rows++)
            {
                for (int cols = 0; cols < 10; cols++)
                {
                    matrix[rows, cols] =  2;
                }
            }*/
            
            Console.WriteLine("The MATRIX: ");
            for (int rows = 0; rows < 10; rows++)
            {
                for (int cols = 0; cols < 10; cols++)
                {
                    Console.Write(matrix[rows, cols] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            Matrix<int> newMatrix = new Matrix<int>(10, 10);
            Matrix<int> matrixSum = new Matrix<int>(10, 10);
            newMatrix[0, 0] = 25;
            matrixSum[0, 0] = 3;
            //newMatrix = matrix;

            matrix = newMatrix * matrixSum;

            Console.WriteLine("NEW MATRIX");
            for (int rows = 0; rows < 10; rows++)
            {
                for (int cols = 0; cols < 10; cols++)
                {
                    Console.Write(matrix[rows, cols] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Testing the ==");
            if (matrix == newMatrix)
            {
                Console.WriteLine("URA");
            }
            else
            {
                Console.WriteLine("NE URA");
            }

        }
    }
}
