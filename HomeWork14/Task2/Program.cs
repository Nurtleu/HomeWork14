using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;


namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load("Information.xml");
            Information info = new Information();
            XmlElement element = xmlDocument.DocumentElement;
            XmlNode classInformation = xmlDocument.CreateElement("Information");
            xmlDocument.DocumentElement.AppendChild(classInformation);
            Console.Write("Введите имя: ");
            XmlNode name = xmlDocument.CreateElement("name");
            info.Name = Console.ReadLine();
            name.InnerText = info.Name;
            classInformation.AppendChild(name);

            Console.Write("Введите фамилию: ");
            XmlNode surname = xmlDocument.CreateElement("surname");
            info.Surname = Console.ReadLine(); 
            surname.InnerText = info.Surname;
            classInformation.AppendChild(surname);

            Console.Write("Введите Отчество: ");
            XmlNode patronymic = xmlDocument.CreateElement("Patronymic");
            info.Patronymic = Console.ReadLine(); 
            surname.InnerText = info.Patronymic;
            classInformation.AppendChild(patronymic);

            Console.Write("Введите возраст: ");
            XmlNode age = xmlDocument.CreateElement("age");
            info.Age = Console.ReadLine(); 
            age.InnerText = info.Age;
            classInformation.AppendChild(age);

            Console.Write("Введите специальность: ");
            XmlNode expert = xmlDocument.CreateElement("expert");
            info.Expert = Console.ReadLine(); 
            expert.InnerText = info.Expert;
            classInformation.AppendChild(expert);

            xmlDocument.Save("Information.xml");
            Console.ReadLine();
        }
    }
}
