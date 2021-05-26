
using UnityEngine;
using UnityEditor;

public class Tools : Editor
{
    [MenuItem("Tools/SetAB_Tag")]
    static void SetABAndTag()
    {
        string assetPath = "Assets/ab";


        string[] uids = AssetDatabase.FindAssets("t:Prefab t:Texture", new string[] { assetPath });
        if (uids == null)
        {
            return;
        }
        string uid, filePath, abName, tag;
        TextureImporter textureImporter;
        AssetImporter assetImporter;
        string[] files;


        for (int i = 0; i < uids.Length; i++)
        {
            uid = uids[i];
            filePath = AssetDatabase.GUIDToAssetPath(uid);

            assetImporter = AssetImporter.GetAtPath(filePath);
            if (assetImporter == null)
            {
                continue;
            }
            abName = filePath.Remove(0, assetPath.Length + 1);
            files = abName.Split('/');
            if (files.Length <= 1)
            {
                continue;
            }

            abName = files[0]; tag = files[files.Length - 2];
            assetImporter.assetBundleName = abName;
            assetImporter.assetBundleVariant = "";

            if (assetImporter is TextureImporter)//Texture
            {
                textureImporter = (TextureImporter)assetImporter;
                if (textureImporter == null)
                {
                    continue;
                }
                textureImporter.spritePackingTag = tag;
            }

            //Debug.Log(Strings.Join("filePath  :", filePath));
        }


        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();

        EditorUtility.DisplayDialog("MyTool", "Have Set All", "OK", "");
    }
}