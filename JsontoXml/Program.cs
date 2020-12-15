using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

namespace JsontoXml
{
   public class Program
    {
        public static void Main(string[] args)
        {
            string path = @"C:\Users\Devis\Downloads\Jsontobeconvertedtoxml.json";
            
            string json = File.ReadAllText(path);

            var xmlobj = JsonConvert.DeserializeObject<Root>(json);

            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            doc.se

            XDocument document = new XDocument();
            List<XAttribute> attribList = new List<XAttribute>();
            foreach ( var attrib in xmlobj.attributes)
            {
                attribList.Add(new XAttribute(attrib.Name, ""));
            }
            document.Add(new XElement(xmlobj.name, attribList));

            var subtag = xmlobj.subTags;
            var tempParentNode = xmlobj.name; 

            while(subtag.Any())
            {
                foreach(var childsubtag in subtag)
                {
                    document.Element(tempParentNode).Add(new XElement(childsubtag.Name));
                    if (childsubtag.SubTags.Any())
                        tempParentNode = childsubtag.Name;
                }
                
               
            }



            document.Save(Console.Out);

             void AddSubtag(string parent, string child)
            {
                
            }

        }
 
     



    }
}
