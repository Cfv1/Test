using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace Test_1
{
    public class Logic
    {
        public static Layer xmlToObj(string inputText)
        {
            Layer layer = new Layer();
            FileStream fs = new FileStream(inputText, FileMode.OpenOrCreate);
            TextReader xml = new StreamReader(fs);
            XmlSerializer serializer = new XmlSerializer(typeof(Layer));
            layer = (Layer)serializer.Deserialize(xml);
            return layer;
        }
    }
}
