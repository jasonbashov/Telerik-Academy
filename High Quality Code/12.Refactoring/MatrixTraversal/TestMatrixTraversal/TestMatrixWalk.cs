using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;
using MatrixTraversal;

namespace MatrixWalkTest
{
    [TestClass]
    public class MatrixWalkTest
    {
        [TestMethod]
        public void TestPrintMatrix()
        {
            int[,] matrix = new int[3, 3] { {1, 0, 0 },
                                           {0, 2, 0 },
                                           {0, 0, 3 }};
            string matrixTostrng = "  1  0  0\r\n  0  2  0\r\n  0  0  3\r\n";
            StringBuilder sb = new StringBuilder();
            Console.SetOut(new System.IO.StringWriter(sb));
            MatrixTraversal.MatrixWalk.PrintMatrix(matrix);
            Assert.AreEqual(matrixTostrng, sb.ToString(), "PringMatrix not working.");
        }

        [TestMethod]
        //TestInputNumberIsEqualToMatrixSize
        public void TestMainMetod()
        {
            string matrixSize = "6";
            Console.SetIn(new System.IO.StringReader(matrixSize));
            StringBuilder sb = new StringBuilder();
            Console.SetOut(new System.IO.StringWriter(sb));
            MatrixTraversal.MatrixWalk.Main();
            string matrixTostrng = @"Enter a positive number between 1-100:
  1 16 17 18 19 20
 15  2 27 28 29 21
 14 31  3 26 30 22
 13 36 32  4 25 23
 12 35 34 33  5 24
 11 10  9  8  7  6
";

            Assert.AreEqual(matrixTostrng, sb.ToString(), "PrintMatrix not working.");
        }
    }
}