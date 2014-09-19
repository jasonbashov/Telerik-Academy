using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FillAndPrintMatrix
{
    //>>>>>>>>>>>>>>>>>>>>>>>>>>> a) solution<<<<<<<<<<<<<<<<<<<<<<<<<<

    static void SubtaskA(int limit, int[,] matrix)
    {
        int fillament = 1;
        for (int col = 0; col < limit; col++)
        {
            //int fillament = 1 + col;
            for (int row = 0; row < limit; row++)
            {
                matrix[row, col] = fillament;
                fillament++;
            }
        }
    }

    //>>>>>>>>>>>>>>>>>>>>>>>>>>> b) solution<<<<<<<<<<<<<<<<<<<<<<<<<<

    static void SubtaskB(int limit, int[,] matrix)
    {

        bool down = true;
        int fillament = 1;
        for (int col = 0; col < limit; col++)
        {
            if (down)
            {
                for (int row = 0; row < limit; row++)
                {
                    matrix[row, col] = fillament;
                    fillament++;
                }
                down = false;
            }
            else
            {
                for (int row = limit - 1; row >= 0; row--)
                {
                    matrix[row, col] = fillament;
                    fillament++;
                }
                down = true;
            }
        }
    }

    //>>>>>>>>>>>>>>>>>>>>>>>>>>> c) solution<<<<<<<<<<<<<<<<<<<<<<<<<<

    static void SubtaskC(int n, int[,] matrix)
    {
        bool needRestart = false;//ako e true - "restartira"cursora v nachalna poziciq po row-ovete
        int needRestartStep = 1;//stypkata s koqto shte se "restartira" cursor-a po matricata
        int counterCol = 1;
        int fillament = 2;
        matrix[n - 1, 0] = 1; // tova go set-vam ru4no
        for (int row = n - 1; row >= 0; row--)
        {
            if (needRestartStep == n)// tuk shte vlizame sled kato sme stignali do nai-dolniq desent ygyl ot matricata
            {
                needRestart = false;

                row = 0;//tuk vinagi trqbva da e 0

                for (int col = counterCol; col < n; col++)
                {
                    matrix[row, col] = fillament;
                    fillament++;
                    row++;
                }
                counterCol++;
                if (counterCol == n)//strignali sme gorniq desen ygyl (kraqt)
                {
                    row = 0;
                }
            }

            if (needRestart)//sled 1voto zavyrtane na cikyla trqbva da se prodylji ot tazi chast na koda
            {
                row -= needRestartStep;
                for (int col = 0; col <= needRestartStep; col++)
                {
                    matrix[row, col] = fillament;
                    fillament++;
                    row++;
                }
                needRestartStep++;
            }
            //--------- sled 1voto zavyrtne na cikyla ne trqbva da se vliza pove4e v tazi 4ast ot koda
            if (needRestartStep == 1)
            {
                row--;//ka4va se na po-gorniq row
                for (int col = 0; col <= needRestartStep; col++)
                {
                    matrix[row, col] = fillament;
                    fillament++;
                    row++;
                }
                needRestart = true;
                needRestartStep++;
            }

        }
    }

    //>>>>>>>>>>>>>>>>>>>>>>>>>>> d) solution<<<<<<<<<<<<<<<<<<<<<<<<<<

    static void SubtaskD(int n, int[,] matrix)
    {
        int num = 1;

        for (int i = 0; i < n / 2; i++)
        {


            for (int row = i; row < n - i; row++)
            {
                matrix[row, i] = num;
                num++;
            }

            for (int col = i + 1; col < (n - (i + 1)); col++)
            {
                matrix[(n - (i + 1)), col] = num;
                num++;
            }

            for (int row = (n - (i + 1)); row >= i; row--)
            {
                matrix[row, (n - (i + 1))] = num;
                num++;
            }

            for (int col = (n - (i + 2)); col >= (i + 1); col--)
            {
                matrix[i, col] = num;
                num++;
            }
        }

        //centralnata kletka na matricata trqbva da se zapylni "ry4no" pri n - ne4etno
        if (n % 2 != 0)
        {
            matrix[n / 2, n / 2] = num;
        }

    }

    static void PrintingMatrix(int limit, int[,] matrix)
    {
        for (int row = 0; row < limit; row++)
        {
            for (int col = 0; col < limit; col++)
            {
                Console.Write(matrix[row, col] + " ");
            }
            Console.WriteLine();
        }
    }

    static void Main()
    {
        Console.WriteLine("Enter N:");
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];

        //a) solution
        SubtaskA(n, matrix);

        //a) printing
        Console.WriteLine("A)");
        PrintingMatrix(n, matrix);


        //b) solution
        SubtaskB(n, matrix);


        //b) printing
        Console.WriteLine("B)");
        PrintingMatrix(n, matrix);

        //c) solution
        SubtaskC(n, matrix);

        //c) printing
        Console.WriteLine("C)");
        PrintingMatrix(n, matrix);

        //d) solution
        SubtaskD(n, matrix);

        //d) printing
        Console.WriteLine("D)");
        PrintingMatrix(n, matrix);
    }
}

