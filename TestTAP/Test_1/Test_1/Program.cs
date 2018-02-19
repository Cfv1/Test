using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using Newtonsoft.Json;

namespace Test_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "input.xml";
            string fullPath = Path.GetFullPath(fileName);
            string myPath = args[0];
            if(fullPath == myPath)
            {
                var obj = Logic.xmlToObj(fileName);
                string json = JsonConvert.SerializeObject(obj, Formatting.Indented);
                Console.WriteLine(json);
            }
            else if (!File.Exists(myPath))
            {
                Console.WriteLine("ERROR: Ошибка пути.");
            }
            Console.ReadLine();
        }
    }
}
