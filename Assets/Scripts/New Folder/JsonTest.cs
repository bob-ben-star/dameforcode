using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Xml;

public class JsonTest : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

        string s=JsonUtility.ToJson(new TestClass { Name="Xiao Ming",Age=30, Sts = new List<string> { "5", "i" }});

        print($"json序列化之后的值为：\n{s}");
        TestClass o = JsonUtility.FromJson<TestClass>(s);

        print($"json反序列化之后的结果为：\n{o}");
        
    }



}
