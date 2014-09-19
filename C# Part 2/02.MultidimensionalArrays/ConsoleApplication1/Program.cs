using System;
 
 
class Matrix
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        int row = 0;
        int col = 0;
        string direction = "down";
        int maxRotations = n * n;
        for (int i = 1; i <= maxRotations; i++)
        {
            if (direction == "down" && (row > n - 1))
            {
                direction = "up";
                row--;
                col++;
            }
            if (direction == "up" && (row < 0))
            {
                direction = "down";
                row++;
                col++;
            }
            matrix[row, col] = i;
 
            if (direction == "down")
            {
                row++;
            }
            if (direction == "up")
            {
                row--;
            }
 
        }
 
        for (int r = 0; r < n; r++)
        {
            for (int c = 0; c < n; c++)
            {
                Console.Write("{0,3}", matrix[r, c]);
            }
            Console.WriteLine();
        }
    }
}