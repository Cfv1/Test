﻿using System;
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
    public class LegendUrl
    {
        [DataMember]
        [XmlElement("Format")]
        public string Format { get; set; }
    }
}
