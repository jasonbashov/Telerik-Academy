namespace TraversingDirectory
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml;

    //09.Write a program to traverse given directory and write to a XML file its contents together with all
    //subdirectories and files. Use tags <file> and <dir> with appropriate attributes. 
    //For the generation of the XML document use the class XmlWriter.

    class Program
    {
        static void Main()
        {
            string fileName = "../../directoryTree.xml";
            Encoding encoding = Encoding.GetEncoding("windows-1251");

            string path = "..\\..\\";

            using (XmlTextWriter writer = new XmlTextWriter(fileName, encoding))
            {
                writer.Formatting = Formatting.Indented;
                writer.IndentChar = '\t';
                writer.Indentation = 1;

                writer.WriteStartDocument();
                writer.WriteStartElement("directories");
                ProcessFiles(path, writer);
                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
        }

        static void ProcessFiles(string path, XmlTextWriter writer)
        {
            string[] files;
            string[] directories;

            files = Directory.GetFiles(path);
            foreach (string file in files)
            {
                var lastIndexOfBackslash = file.LastIndexOf("\\");
                var fileName = file.Substring(lastIndexOfBackslash + 1);
                writer.WriteStartElement("file");
                writer.WriteElementString("name", fileName);
                writer.WriteEndElement();
            }

            directories = Directory.GetDirectories(path);
            foreach (string directory in directories)
            {
                // Process each directory recursively
                var lastIndexOfBackslash = directory.LastIndexOf("\\");
                var dirName = directory.Substring(lastIndexOfBackslash + 1);

                writer.WriteStartElement("dir");
                writer.WriteElementString("name", dirName);

                ProcessFiles(directory, writer);

                writer.WriteEndElement();
            }
        }
    }
}
