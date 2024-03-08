using System.Text;
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

        }
    }
}
