using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace Test_1
{
    [Serializable]
    [DataContract]
    public class Attribute
    {
        [DataMember]
        [XmlAttribute("name")]
        public string name { get; set; } = "";

        [DataMember]
        [XmlAttribute("type")]
        public string type { get; set; } = "";
    }
}
