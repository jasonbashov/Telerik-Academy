namespace TraversDirWithXElement
{
    using System.IO;
    using System.Xml.Linq;

    //10.Rewrite the last exercises using XDocument, XElement and XAttribute.
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "../../directoryTree.xml";

            string path = "..\\..\\";

            XElement dirsXml = new XElement("directories");
            ProcessFiles(path, dirsXml);
            dirsXml.Save(fileName);
        }

        static void ProcessFiles(string path, XElement dirsXml)
        {
            string[] files;
            string[] directories;

            files = Directory.GetFiles(path);
            foreach (string file in files)
            {
                var lastIndexOfBackslash = file.LastIndexOf("\\");
                var fileName = file.Substring(lastIndexOfBackslash + 1);

                var fileXml = new XElement("file",
                    new XElement("name", fileName));

                dirsXml.Add(fileXml);
            }

            directories = Directory.GetDirectories(path);
            foreach (string directory in directories)
            {
                // Process each directory recursively
                var lastIndexOfBackslash = directory.LastIndexOf("\\");
                var dirName = directory.Substring(lastIndexOfBackslash + 1);

                var subDirXml = new XElement("dir",
                    new XElement("name", dirName));
                ProcessFiles(directory, subDirXml);
                dirsXml.Add(subDirXml);
            }
        }
    }
}
