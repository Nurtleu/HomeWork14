using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace HomeWork14
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Item> item = new List<Item>();
            XmlDocument xml = new XmlDocument();
            xml.LoadXml= ("https://habrahabr.ru/rss/interesting/");
            XmlElement xmlDocument = xml.DocumentElement;
            
            if (xmlDocument.HasChildNodes)
            {
                foreach (XmlElement node in xmlDocument.ChildNodes)
                {
                    if (xml.Name=="items")
                    {
                        Item items = new Item();
                        items.Link = node["link"].InnerText;
                        items.Descripsion = node["descripsion"].InnerText;
                        items.PubDate = node["pubdate"].InnerText;
                        items.Title = node["title"].InnerText;
                    }
                }
                foreach(var text in item)
                {
                    Console.WriteLine(text.Link);
                    Console.WriteLine(text.PubDate);
                    Console.WriteLine(text.Title);
                    Console.WriteLine(text.Descripsion);
                }
            }

        }
    }
}
