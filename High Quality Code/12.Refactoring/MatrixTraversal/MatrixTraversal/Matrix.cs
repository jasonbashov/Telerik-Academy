using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixTraversal
{
    public class Matrix
    {
        public static void ChangeDirections(ref int nextStepX, ref int nextStepY)
        {
            int[] movementsX = {1, 1, 1, 0, -1, -1, -1, 0 };
            int[] movementsY = {1, 0, -1, -1, -1, 0, 1, 1 };
            int counterMovements = 0;

            for (int i = 0; i < 8; i++)
            {
                if (movementsX[i] == nextStepX && movementsY[i] == nextStepY)
                {
                    counterMovements = i; 
                    break;
                }
            }

            if (counterMovements == 7)
            {
                nextStepX = movementsX[0];
                nextStepY = movementsY[0];
                return;
            }

            nextStepX = movementsX[counterMovements + 1];
            nextStepY = movementsY[counterMovements + 1];
        }

        public static bool CheckNeighbourCellsForAvaibleMove(int[,] arr, int currXMovement, int currYMovement)
        {
            int[] movementsX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] movementsY = { 1, 0, -1, -1, -1, 0, 1, 1 };

            for (int i = 0; i < 8; i++)
            {
                if (currXMovement + movementsX[i] >= arr.GetLength(0) || currXMovement + movementsX[i] < 0)
                {
                    movementsX[i] = 0;
                }
                if (currYMovement + movementsY[i] >= arr.GetLength(0) || currYMovement + movementsY[i] < 0)
                {
                    movementsY[i] = 0;
                }
            }

            for (int i = 0; i < 8; i++)
            {
                if (arr[currXMovement + movementsX[i], currYMovement + movementsY[i]] == 0)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool FindEmptyCell(int[,] arr, out int x, out int y)
        {
            x = 0;
            y = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    if (arr[i, j] == 0)
                    {
                        x = i;
                        y = j;
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
