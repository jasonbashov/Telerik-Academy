//1.Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space. 
//Implement the ToString() to enable printing a 3D point.

//2.Add a private static read-only field to hold the start of the coordinate system – the point O{0, 0, 0}.
//Add a static property to return the point O.

//3.Write a static class with a static method to calculate the distance between two points in the 3D space.

//4.Create a class Path to hold a sequence of points in the 3D space. 
//Create a static class PathStorage with static methods to save and load paths from a text file. Use a file format of your choice.
namespace _01.Euclidian3DSpace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public struct Point3D
    {
        private static readonly Point3D coordinateSysStart = new Point3D(0,0,0);
        private int x;
        private int y;
        private int z;

        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Point3D(int x, int y, int z)
            : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public override string ToString()
        {
            return String.Format("({0},{1},{2})", X, Y, Z);
        }

        public static Point3D Point0()
        {
            return coordinateSysStart;
        }
    }
}
