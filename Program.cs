using System;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using System.IO;
using System.Collections;

//(-_-)
namespace xml_lab_2
{
    class Program
    {

        public static void T1V()
        {
            string path = @"C:\Users\Student\Desktop\xml_lab_2\File.xml";

            XDocument xdocument = XDocument.Load(path);

            Console.WriteLine(xdocument.ToString());
            Console.WriteLine("________");
            foreach (var element in xdocument.Root.Elements())
            {
                var max = (from e in element.Descendants() select e.Attributes().Count()).DefaultIfEmpty(-1).Max();

                var a = (from e in element.Descendants() where e.Attributes().Count() == max let name = e.Name.LocalName orderby name  select name).DefaultIfEmpty("no child");

                foreach (var e in a)
                {
                    Console.WriteLine($"{e} [{max}]");
                }

            }

            Console.WriteLine("________");
        }

        static void Main(string[] args)
        {
            T1V();
            Console.ReadKey();
        }
    }
}
