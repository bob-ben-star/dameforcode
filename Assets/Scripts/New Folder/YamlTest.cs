using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using YamlDotNet;
using YamlDotNet.Serialization;
public class YamlTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        Serializer serializer = new Serializer();
        string s=serializer.Serialize(new TestClass {
            Name="Yaml",
            Age=66 ,
            Sts=new List<string> { "5","i"},
           
        });
        print($"Yaml序列化之后的值为：\n{s}");
        Deserializer deserializer = new Deserializer();
        TestClass res = deserializer.Deserialize<TestClass>(s);
        print($"Yaml反序列化之后的结果为：\n{res}");
        /*
        using (MemoryStream ms=new MemoryStream())
        {
            using (StreamWriter tw = new StreamWriter(ms))
            {
                
            }
        }
        */
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
