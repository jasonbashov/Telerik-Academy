using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];

        int num = 1;

        for (int i = 0; i < n / 2; i++)
        {


            for (int col = i; col < n - i; col++)
            {
                matrix[i, col] = num;
                num++;
            }

            for (int row = i+1; row < (n - (i+1)); row++)
            {
                matrix[row, (n - (i + 1))] = num;
                num++;
            }

            for (int col = (n - (i + 1)); col >= i; col--)
            {
                matrix[(n - (i + 1)), col] = num;
                num++;
            }

            for (int row = (n - (i + 2)); row >= (i + 1); row--)
            {
                matrix[row, i] = num;
                num++;
            }
        }
        /*for (int col = (n-3); col <= (n-2); col++)
        {
            matrix[n - 3, col] = num;
            num++;
        }

        for (int row = (n-3); row <= (n-2); row++)
        {
            matrix[row, n - 2] = num;
            num++;
        }

        for (int col = 0; col < length; col++)
        {
            
        }*/

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write(matrix[row,col] + "   ");
            }
            Console.WriteLine();
        }
    }
}

