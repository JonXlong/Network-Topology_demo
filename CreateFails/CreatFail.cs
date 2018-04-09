using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class CreatFail : MonoBehaviour {
#if UNITY_EDITOR
    // Use this for initialization
    [MenuItem("Tool/CreatBaseFolder")]
    public static void CreatBaseFolder()
    {
        CreatFolder(0);
    }
    [MenuItem("Tool/CreateAllFolder")]
    public static void CreatAllFolder()
    {
        CreatFolder(1);
    }
	[MenuItem("Tool/CreateMyFolder")]
	public static void CreateMyFolder()
	{
		CreatFolder(2);
	}
    private static void CreatFolder(int _i)
    {
        //文件路径
        string path = Application.dataPath + "/";
        Directory.CreateDirectory(path+ "Audio");
        Directory.CreateDirectory(path + "Scenes");
        Directory.CreateDirectory(path+"Prefabs");
        Directory.CreateDirectory(path + "Texture");
        Directory.CreateDirectory(path + "Resources");
        Directory.CreateDirectory(path + "Scripts");
        Directory.CreateDirectory(path+"Materials");
        if (_i==1)
        {
            Directory.CreateDirectory(path+"Meshes");
            Directory.CreateDirectory(path+"Shaders");
            Directory.CreateDirectory(path+"GUI");
        }
		if(_i==2)
		{
			Directory.CreateDirectory(path+"MyScripts");
			Directory.CreateDirectory(path+"MyPrefabs");
			Directory.CreateDirectory(path+"MyPreafabs/"+"MyMaterials");
		}
        AssetDatabase.Refresh();
    }
#endif
}
