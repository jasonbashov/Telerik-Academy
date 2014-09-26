//4.Create a class Path to hold a sequence of points in the 3D space. Create a static class PathStorage with 
//static methods to save and load paths from a text file. Use a file format of your choice.

namespace _01.Euclidian3DSpace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.IO;

    class PathStorage
    {
        public static void SavePath(Path pathToSave)
        {
            var fs = File.Open(@"..\..\Paths.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            var sw = new StreamWriter(fs);

            using (sw)
            {
                foreach (var p in pathToSave.ListOfPoints)
                {
                    sw.WriteLine("{0} ", p.ToString());
                }
            }

            fs.Close();
        }

        public static Path LoadPath(string location)
        {
            Path loadPath = new Path();
            try
            {
                using (StreamReader reader = new StreamReader(@location))
                {
                    while (reader.Peek() >= 0)
                    {
                        String line = reader.ReadLine();
                        String[] splittedLine = line.Split(new char[] { '(', ',', ')' }, StringSplitOptions.RemoveEmptyEntries);
                        loadPath.AddPoint(new Point3D(int.Parse(splittedLine[0]), int.Parse(splittedLine[1]), int.Parse(splittedLine[2])));
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found, try adding a new file");
            }
            catch (IOException io)
            {
                Console.WriteLine(io.Message);
            }
            catch (OutOfMemoryException ome)
            {
                Console.WriteLine(ome.Message);
            }
            finally { }
            return loadPath;
        }
    }
}
