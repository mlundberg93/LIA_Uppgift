using System.Xml;

namespace LIA_Uppgift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileName = "sma_gentext.xml";
            string docPath = Path.Combine(Directory.GetCurrentDirectory(), fileName);

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(docPath);

            XmlNode search = xmlDoc.SelectSingleNode("//trans-unit[@id='42007']/target");
            string value = search.InnerText;
            Console.WriteLine("value: " + value);
            Console.ReadLine();

        }
    }
}
