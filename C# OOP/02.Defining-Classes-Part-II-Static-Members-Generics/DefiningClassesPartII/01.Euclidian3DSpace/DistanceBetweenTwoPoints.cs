//3.Write a static class with a static method to calculate the distance between two points in the 3D space.
namespace _01.Euclidian3DSpace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class DistanceBetweenTwoPoints
    {
        public static int CalculateDistance(Point3D point1, Point3D point2)
        {
            int deltaX = point1.X - point2.X;
            int deltaY = point1.Y - point2.Y;
            int deltaZ = point1.Z - point2.Z;

            int distance = (int)Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);

            return distance;
        }

    }
}
