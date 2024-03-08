using System.Xml;

namespace LIA_Uppgift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //XML-fil läggs i följande mapstruktur: ..\..\Source\Repos\MyProjects\LIA_Uppgift\bin\Debug\net8.0\sma.gentext.xml
            string fileName = "sma_gentext.xml";
            string docPath = Path.Combine(Directory.GetCurrentDirectory(), fileName);

            //Läser in XML-dokumentet
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(docPath);

            //Sökning efter element
            XmlNode search = xmlDoc.SelectSingleNode("//trans-unit[@id='42007']/target");
            string value = search.InnerText;

            //Skapar och skriver value till ny fil
            string createFile = "XML-Data.txt";
            File.WriteAllText(createFile, value);

            Console.WriteLine($"The data {value} has been saved to the file {createFile}");
            Console.WriteLine("Press enter to exit..");
            Console.ReadLine();
        }
    }
}
