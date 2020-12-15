using System;
using System.Collections.Generic;
using System.Text;

namespace JsontoXml
{
    public class Attribute
    {
        public string Name { get; set; }
        public string DataType { get; set; }
        public string DefinedType { get; set; }
        public string Type { get; set; }
        public string Required { get; set; }
        public string Annotation { get; set; }
    }


    public class SubTag
    {
        public string Name { get; set; }
        public string DataType { get; set; }
        public string DefinedType { get; set; }
        public string Type { get; set; }
        public string Required { get; set; }
        public string Annotation { get; set; }
        public List<Attribute> Attributes { get; set; }
        public List<SubTag> SubTags { get; set; }
    }

    public class Root
    {
        public string name { get; set; }
        public string status { get; set; }
        public List<Attribute> attributes { get; set; }
        public List<SubTag> subTags { get; set; }
    }

}
