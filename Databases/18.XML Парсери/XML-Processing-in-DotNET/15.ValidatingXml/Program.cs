namespace ValidatingXml
{
    using System;
    using System.Xml.Linq;
    using System.Xml.Schema;

    //15.Using Visual Studio generate an XSD schema for the file catalog.xml. Write a C# program that takes an
    //XML file and an XSD file (schema) and validates the XML file against the schema. Test it with valid XML 
    //catalogs and invalid XML catalogs.

    class Program
    {
        static void Main()
        {
            XmlSchemaSet schemas = new XmlSchemaSet();
            schemas.Add("", "../../CatalogSchema.xsd");

            //Valid xml file
            XDocument doc = XDocument.Load("../../catalog.xml");

            //Invalid xml file
            XDocument invalidDoc = XDocument.Load("../../InvalidCatalog.xml");
            string msg = "";
            doc.Validate(schemas, (o, e) =>
            {
                msg = e.Message;
            });
            Console.WriteLine(msg == "" ? "Document catalog.xml is valid" : "Document catalog.xml invalid: " + msg);

            invalidDoc.Validate(schemas, (o, e) =>
            {
                msg = e.Message;
            });
            Console.WriteLine(msg == "" ? "Document InvalidCatalog.xml is valid" : "Document InvalidCatalog.xml invalid: " + msg);
        }
    }
}
