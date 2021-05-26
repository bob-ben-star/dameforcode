using System.Collections.Generic;
using UnityEngine;

public class TestClass
{
    public string Name;
    public int Age;
    public override string ToString()
    {
        return $"Name={Name},Age={Age},Sts.Count={Sts?.Count}";
    }

    public List<string> Sts;


}