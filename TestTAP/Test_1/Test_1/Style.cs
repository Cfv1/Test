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
    public class Style
    {
        [XmlElement("Name")]
        [DataMember]
        public string Name { get; set; }

        [XmlElement("Title")]
        [DataMember]
        public string Title { get; set; } = "";

        [XmlElement("LegendURL")]
        [DataMember]
        public List<LegendUrl> LegendUrl { get; set; }
    }
}
