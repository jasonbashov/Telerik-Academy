using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MatrixTraversal;

namespace TestMatrixTraversal
{
    [TestClass]
    public class TestMatrix
    {
        [TestMethod]
        public void TestChangeWalkDirectionTopLeftDiagonal()
        {
            int dx = 1;
            int dy = 1;
            Matrix.ChangeDirections(ref dx, ref dy);
            Assert.AreEqual(1, dx);
            Assert.AreEqual(0, dy);
        }

        [TestMethod]
        public void TestChangeWalkDirectionLeftDiagonal()
        {
            int dx = 1;
            int dy = 0;
            Matrix.ChangeDirections(ref dx, ref dy);
            Assert.AreEqual(1, dx);
            Assert.AreEqual(-1, dy);
        }

        [TestMethod]
        public void TestChangeWalkDirectionLeftBottomDiagonal()
        {
            int dx = 1;
            int dy = -1;
            Matrix.ChangeDirections(ref dx, ref dy);
            Assert.AreEqual(0, dx);
            Assert.AreEqual(-1, dy);
        }

        [TestMethod]
        public void TestChangeWalkDirectionBottomDiagonal()
        {
            int dx = 0;
            int dy = -1;
            Matrix.ChangeDirections(ref dx, ref dy);
            Assert.AreEqual(-1, dx);
            Assert.AreEqual(-1, dy);
        }

        [TestMethod]
        public void TestChangeWalkDirectionRightBottomDiagonal()
        {
            int dx = -1;
            int dy = -1;
            Matrix.ChangeDirections(ref dx, ref dy);
            Assert.AreEqual(-1, dx);
            Assert.AreEqual(0, dy);
        }

        [TestMethod]
        public void TestChangeWalkDirectionRightDiagonal()
        {
            int dx = -1;
            int dy = 0;
            Matrix.ChangeDirections(ref dx, ref dy);
            Assert.AreEqual(-1, dx);
            Assert.AreEqual(1, dy);
        }

        [TestMethod]
        public void TestChangeWalkDirectionRightTopDiagonal()
        {
            int dx = -1;
            int dy = 1;
            Matrix.ChangeDirections(ref dx, ref dy);
            Assert.AreEqual(0, dx);
            Assert.AreEqual(1, dy);
        }

        [TestMethod]
        public void TestChangeWalkDirectionTopDiagonal()
        {
            int dx = 0;
            int dy = 1;
            Matrix.ChangeDirections(ref dx, ref dy);
            Assert.AreEqual(1, dx);
            Assert.AreEqual(1, dy);
        }

        [TestMethod]
        public void TesCheckNeighbourCellsForAvaibleMoveFalse()
        {
            int x = 1;
            int y = 1;
            int[,] matrix = new int[3, 3] { {1, 2, 3 },
                                           {4, 2, 6 },
                                           {8, 7, 3 }};
            bool isPosiblDirection = Matrix.CheckNeighbourCellsForAvaibleMove(matrix, x, y);
            Assert.IsFalse(isPosiblDirection, "Return true, but hadn't possible walk direction.");
        }

        [TestMethod]
        public void TestCheckNeighbourCellsForAvaibleMove_One()
        {
            int x = 1;
            int y = 1;
            int[,] matrix = new int[3, 3] { {1, 2, 3 },
                                           {4, 2, 6 },
                                           {8, 7, 0 }};
            bool isPosiblDirection = Matrix.CheckNeighbourCellsForAvaibleMove(matrix, x, y);
            Assert.IsTrue(isPosiblDirection, "It has a possible walk direction, but is not found.");
        }

        [TestMethod]
        public void TestCheckNeighbourCellsForAvaibleMove_Two()
        {
            int x = 1;
            int y = 1;
            int[,] matrix = new int[3, 3] { {1, 2, 3 },
                                           {4, 2, 0 },
                                           {8, 7, 0 }};
            bool isPosiblDirection = Matrix.CheckNeighbourCellsForAvaibleMove(matrix, x, y);
            Assert.IsTrue(isPosiblDirection, "It has a possible walk direction, but is not found.");
        }

        [TestMethod]
        public void TestCheckNeighbourCellsForAvaibleMove_Four()
        {
            int x = 1;
            int y = 1;
            int[,] matrix = new int[3, 3] { {1, 0, 3 },
                                           {0, 2, 0 },
                                           {8, 0, 3 }};
            bool isPosiblDirection = Matrix.CheckNeighbourCellsForAvaibleMove(matrix, x, y);
            Assert.IsTrue(isPosiblDirection, "It has a possible walk direction, but is not found.");
        }

        [TestMethod]
        public void TestCheckNeighbourCellsForAvaibleMove_All()
        {
            int x = 1;
            int y = 1;
            int[,] matrix = new int[3, 3] { {0, 0, 0 },
                                           {0, 1, 0 },
                                           {0, 0, 0 }};
            bool isPosiblDirection = Matrix.CheckNeighbourCellsForAvaibleMove(matrix, x, y);
            Assert.IsTrue(isPosiblDirection, "It has a possible walk direction, but is not found.");
        }

        [TestMethod]
        public void TestFindEmptyCellForEmptyMatrix()
        {
            int x;
            int y;
            int[,] matrix = new int[3, 3] { {0, 0, 0 },
                                           {0, 0, 0 },
                                           {0, 0, 0 }};
            bool isFoundCell = Matrix.FindEmptyCell(matrix, out x, out y);
            Assert.IsTrue(isFoundCell, "Cell not found");
            Assert.AreEqual(0, x, "Found element has wrong x position.");
            Assert.AreEqual(0, y, "Found element has wrong y position.");
        }

        [TestMethod]
        public void TestFindEmptyCellForAllFullMatrix()
        {
            int x;
            int y;
            int[,] matrix = new int[3, 3] { {1, 7, 8 },
                                           {6, 2, 9 },
                                           {5, 4, 3 }};
            bool isFoundCell = Matrix.FindEmptyCell(matrix, out x, out y);
            Assert.IsFalse(isFoundCell, "Cell found");
        }

        [TestMethod]
        public void TestFindEmptyCellForSemiFullMatrix()
        {
            int x;
            int y;
            int[,] matrix = new int[3, 3] { {1, 7, 8 },
                                           {0, 0, 9 },
                                           {0, 0, 0 }};
            bool isFoundCell = Matrix.FindEmptyCell(matrix, out x, out y);
            Assert.IsTrue(isFoundCell, "Cell not found");
            Assert.AreEqual(1, x, "Found element has wrong x position.");
            Assert.AreEqual(0, y, "Found element has wrong y position.");
        }

        [TestMethod]
        public void TestFindEmptyCellForSemiFullMatrix1()
        {
            int x;
            int y;
            int[,] matrix = new int[3, 3] { {1, 7, 8 },
                                           {4, 2, 0 },
                                           {5, 0, 0 }};
            bool isFoundCell = Matrix.FindEmptyCell(matrix, out x, out y);
            Assert.IsTrue(isFoundCell, "Cell not found");
            Assert.AreEqual(1, x, "Found element has wrong x position.");
            Assert.AreEqual(2, y, "Found element has wrong y position.");
        }
    }
}
