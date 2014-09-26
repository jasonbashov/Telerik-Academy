namespace _01.Euclidian3DSpace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Testing
    {
        static void Main()
        {
            Point3D firstPoint = new Point3D(1, 1, 1);
            Point3D secondPoint = new Point3D(2, 2, 2);
            Point3D thirdPoint = new Point3D(3, 4, 5);

            Console.WriteLine("Start point: {0}", Point3D.Point0());
            Console.WriteLine("Point 1: {0}", firstPoint.ToString());
            Console.WriteLine("Point 2: {0}", secondPoint.ToString());

            Console.WriteLine("Distance: {0}", DistanceBetweenTwoPoints.CalculateDistance(firstPoint, secondPoint));

            Path newPath = new Path();

            newPath.AddPoint(firstPoint);
            newPath.AddPoint(secondPoint);
            newPath.AddPoint(thirdPoint);

            PathStorage.SavePath(newPath);

            Console.WriteLine();

            Path loadedPath = PathStorage.LoadPath("../../Paths.txt");

            foreach (var point in loadedPath.ListOfPoints)
            {
                Console.WriteLine("{0}", point);
            }
        }
    }
}
