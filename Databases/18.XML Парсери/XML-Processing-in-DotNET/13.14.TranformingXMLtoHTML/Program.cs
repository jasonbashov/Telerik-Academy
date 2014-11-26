namespace TranformingXMLtoHTML
{
    using System.Xml.Xsl;

    class Program
    {
        static void Main()
        {
            XslCompiledTransform xslt = new XslCompiledTransform();
            xslt.Load("../../CatalogToHtml.xsl");
            xslt.Transform("../../catalog.xml", "../../Catalog.html");
            System.Console.WriteLine("HTML Created successfuly");
        }
    }
}
