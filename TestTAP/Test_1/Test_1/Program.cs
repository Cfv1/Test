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
            string myPath = args[0];
            string directoryName = Path.GetDirectoryName(myPath);
            string fileName = Path.GetFileName(myPath);
            string[] extensionArr = fileName.Split('.');
            string extension = extensionArr[extensionArr.Length - 1];
            if (File.Exists(Path.Combine(directoryName, fileName)) && extension == "xml")
            {
                var obj = Logic.xmlToObj(fileName);
                string json = JsonConvert.SerializeObject(obj, Formatting.Indented);
                Console.WriteLine(json);
            }
            else if (File.Exists(Path.Combine(directoryName, fileName)) && extension != "xml")
            {
                Console.WriteLine("ERROR: Нужен файл с расширением .xml");
            }
            else
            {
                Console.WriteLine("ERROR: Файла {0} не существует по пути {1}", fileName, directoryName);
            }

            Console.ReadLine();
        }
    }
}
