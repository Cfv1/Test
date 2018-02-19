using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Test_1
{
    [Serializable]
    [DataContract]
    [XmlRoot("Layer")]
    public class Layer
    {
        [XmlElement("Name")]
        [DataMember]
        public string Name { get; set; }

        [XmlElement("Sublayer")]
        [DataMember]
        public List<Sublayer> Sublayers { get; set; }
    }
}
