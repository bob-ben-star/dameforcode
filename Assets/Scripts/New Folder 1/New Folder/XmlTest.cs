using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml.Serialization;
using System.IO;
using System.Text;
public class XmlTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TestClass xmlTestClass = new TestClass { Name = "Bob", Age = 10, Sts = new List<string> { "5", "i" },
            
        };
        XmlSerializer xmlSerializer1 = new XmlSerializer(typeof(TestClass));
        string haveSaveString=string.Empty;
        using (MemoryStream ms=new MemoryStream())
        {
            xmlSerializer1.Serialize(ms,xmlTestClass);
            print($"xml序列化之后的值为：\n{(haveSaveString = Encoding.UTF8.GetString(ms.ToArray()))}");
        }
        

        XmlSerializer xmlSerializer2 = new XmlSerializer(typeof(TestClass));
        using (MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(haveSaveString)))
        {
            TestClass deSerializerRes= xmlSerializer2.Deserialize(ms) as TestClass;

            print($"xml反序列化之后的结果为：\n{deSerializerRes}");
        }
    }



}

