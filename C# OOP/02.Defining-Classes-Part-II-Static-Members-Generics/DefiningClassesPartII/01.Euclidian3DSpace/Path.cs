//4.Create a class Path to hold a sequence of points in the 3D space. 
//Create a static class PathStorage with static methods to save and load paths from a text file. Use a file format of your choice.

namespace _01.Euclidian3DSpace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    class Path 
    {
        private static List<Point3D> listOfPoints;

        public Path()
        {
            listOfPoints = new List<Point3D>();
        }

        public List<Point3D> ListOfPoints
        {
            get
            {
                return listOfPoints;
            }
        }

        public static void ClearPath()
        {
            Path path = new Path();
            listOfPoints.Clear();
        }

        public void AddPoint(Point3D point)
        {
            listOfPoints.Add(point);
        }

        public void PrintPathList()
        {
            foreach (var p in listOfPoints)
            {
                Console.WriteLine("({0})", p.ToString());
            }
        }
        /*System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return (this as IEnumerable<Point3D>).GetEnumerator();
        }*/
        /*public IEnumerator<KeyValuePair<int, int>> GetEnumerator()
        {
            return paramids.GetEnumerator();
        }*/

        /*System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }*/
    }
}
