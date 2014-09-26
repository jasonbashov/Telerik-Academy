//8.Define a class Matrix<T> to hold a matrix of numbers (e.g. integers, floats, decimals). 
//
//9.Implement an indexer this[row, col] to access the inner matrix cells.
//
//10.Implement the operators + and - (addition and subtraction of matrices of the same size) 
//and * for matrix multiplication. Throw an exception when the operation cannot be performed. 
//Implement the true operator (check for non-zero elements).

namespace _08.DefiningMatrixGeneric
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Matrix<T>  where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {
        private int rows;
        private int cols;
        private T[,] matrix;

        #region Constructors
        /*public T this[int x, int y]
        {
            get { return matrix[x, y]; }
            set { matrix[x, y] = value; }
        }*/
        public Matrix(int rows, int cols)
        {
            this.matrix = new T[rows, cols];
            this.rows = rows;
            this.cols = cols;
            // a constructor which row and col are the sizes of the matrix
        }
        public Matrix(int rows, int cols, T[,] matrix)
        {
            this.rows = rows;
            this.cols = cols;
            this.matrix = matrix;
        }
        #endregion 

        #region Properties

        public int Rows
        {
            get { return rows; }
            set 
            {
                if (value <= 0 )
                {
                    throw new IndexOutOfRangeException("Index is too small for coloumns!");
                }
                this.rows = value;
            }
        }
        public int Cols
        {
            get { return cols; }
            set 
            {
                if (value <= 0)
                {
                    throw new IndexOutOfRangeException("Index is too small for coloumns!");
                }
                this.cols = value;
            }
        }

        public T this[int rows, int cols]
        {
            get
            {
                if (rows < 0 || cols < 0 || rows >= this.rows || cols >= this.cols )
                {
                    throw new IndexOutOfRangeException("Index is out of range");
                }

                return this.matrix[rows, cols];
            }
            set
            {
                if (rows < 0 || cols < 0 || rows >= this.rows || cols >= this.cols)
                {
                    throw new IndexOutOfRangeException("Index is out of range");
                }

                this.matrix[rows, cols] = value;
            }
        }
        #endregion

        private static T[,] ImportMatrixToArray(Matrix<T> matrix)
        {
            T[,] matrixToReturn = new T[matrix.Rows, matrix.Cols];

            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Cols; j++)
                {
                    matrixToReturn[i, j] = matrix[i, j];
                }
            }

            return matrixToReturn;
        }

        private static T[,] Addition(T[,] firstMatrix, T[,] secondMatrix, Func<T, T, T> op)
        {
            T[,] matrixToReturn = new T[firstMatrix.GetLength(0), firstMatrix.GetLength(1)];
            T temp;
            //temp = a;
            //a = op(a, b);
            for (int i = 0; i < firstMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < firstMatrix.GetLength(1); j++)
                {
                    temp = firstMatrix[i, j];
                    matrixToReturn[i, j] = op(firstMatrix[i, j], secondMatrix[i, j]);
                }
            }
            return matrixToReturn;
        }

        public static Matrix<T> operator +(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            
            if (firstMatrix.Rows != secondMatrix.Rows || firstMatrix.Cols != secondMatrix.Cols)
            {
                throw new ArgumentException("The size of the two matrixes is different");
            }

            Matrix<T> newMatrix = new Matrix<T>(firstMatrix.Rows, firstMatrix.Cols);

            for (int row = 0; row < firstMatrix.Rows; row++)
            {
                for (int col = 0; col < firstMatrix.Cols; col++)
                {
                    newMatrix[row, col] = (dynamic)firstMatrix[row, col] + (dynamic)secondMatrix[row, col];
                }
            }
            return newMatrix;
        }

        public static Matrix<T> operator -(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.Rows != secondMatrix.Rows || firstMatrix.Cols != secondMatrix.Cols)
            {
                throw new ArgumentException("The size of the two matrixes is different");
            }

            Matrix<T> newMatrix = new Matrix<T>(firstMatrix.Rows, firstMatrix.Cols);

            for (int row = 0; row < firstMatrix.Rows; row++)
            {
                for (int col = 0; col < firstMatrix.Cols; col++)
                {
                    newMatrix[row, col] = (dynamic)firstMatrix[row, col] - (dynamic)secondMatrix[row, col];
                }
            }

            return newMatrix;
        }

        public static Matrix<T> operator *(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.Rows != secondMatrix.Rows || firstMatrix.Cols != secondMatrix.Cols)
            {
                throw new ArgumentException("The size of the two matrixes is different");
            }

            Matrix<T> newMatrix = new Matrix<T>(firstMatrix.Rows, firstMatrix.Cols);

            for (int i = 0; i < firstMatrix.Rows; i++)
            {
                for (int j = 0; j < firstMatrix.Cols; j++)
                {
                    dynamic sum = 0;
                    for (int x = 0; x < firstMatrix.Cols; x++)
                    {
                        sum = sum + (dynamic)firstMatrix[i, x] * (dynamic)secondMatrix[x, j];
                    }
                    newMatrix[i, j] = sum;
                }
            }

            return newMatrix;
        }

        //Implement the true operator (check for non-zero elements).
        public static bool operator true(Matrix<T> matrix)
        {
            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Cols; j++)
                {
                    int zero = 0;
                    if (matrix[i, j].CompareTo((T)Convert.ChangeType(zero, typeof(T))) == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static bool operator false(Matrix<T> matrix)
        {
            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Cols; j++)
                {
                    //matr[i, j] == 0
                    int zero = 0;
                    if (matrix[i, j].CompareTo(new T()) == 0)
                    //if (matr[i, j].CompareTo(default(T)) == 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
