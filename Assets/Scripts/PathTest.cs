using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string path;
        path = Application.dataPath;
        path = Application.temporaryCachePath;
        
        
       
        path = Application.persistentDataPath;
        path = Application.consoleLogPath;
        print(path);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
