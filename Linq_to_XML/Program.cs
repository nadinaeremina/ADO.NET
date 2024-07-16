using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Data.Linq;
using System.Configuration;

namespace Linq_to_XML
{
    class Program
    {
        static void XML_doc_func()// создание документа // мы создаем данные в оперативной памяти
        {
            // документ состоит из двух эл-ов - компьютеров 
            XDocument xmldoc = new XDocument(new XElement("computers",
                new XElement("computer", new XAttribute("Price", "800"), new XAttribute("Warranty", "2 years"),
                                         new XElement("CPU", new XAttribute("Name", "Intel Core i7-6700K"), new XAttribute("GHz", 2.5)),
                                         new XElement("HDD", new XAttribute("Name", "Samsung 850 PRO"), new XAttribute("Size", 1.0))),
                new XElement("computer", new XAttribute("Price", "900"), new XAttribute("Warranty", "2 years"),
                                         new XElement("CPU", new XAttribute("Name", "AMD A10-5800K"), new XAttribute("GHz", 2.5)),
                                         new XElement("HDD", new XAttribute("Name", "Transcend ESD400"), new XAttribute("Size", 1.0)))
                )
            );

            Console.WriteLine(xmldoc);

            // наш документ сохраняем в этот файл
            string xml_path = @"test.xml";
            xmldoc.Save(xml_path);
        }
        static void Select_xml()
        {
            XDocument xmldoc = XDocument.Load(@"test.xml");
            // читаем документ из Xaml-файлика

            // ищем, где цена равна 900 // 'Descendants' - потск эл-та
            var res = from c in xmldoc.Descendants(XName.Get("computer"))
                      where Convert.ToInt32(c.Attribute(XName.Get("Price")).Value) == 900
                      select c;

            foreach (var item in res)
                Console.WriteLine(item);
        }
        static void Main(string[] args)
        {
            XML_doc_func();

            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++");

            Select_xml();
        }
    }
}
