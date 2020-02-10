using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using XLua;

[Hotfix]
public class HotFixLoad : MonoBehaviour
{
    LuaEnv luaEnv = new LuaEnv();
    public  static Dictionary<string, GameObject> prefabs = new Dictionary<string, GameObject>();
    // Start is called before the first frame update

    private void Awake()
    {
        luaEnv.AddLoader(Myloader);
        luaEnv.DoString("require'fish'");

    }
    void Start()
    {

    }

    public byte[] Myloader(ref string fileName)
    {
        string absPath = @"H:\0.0\MyDemo\FishingJoy\"+ fileName+".lua.txt";
        return System.Text.Encoding.UTF8.GetBytes(File.ReadAllText(absPath));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDisable()
    {
        luaEnv.DoString("require'fishDispose'");
    }

    private void OnDestroy()
    {
        luaEnv.Dispose();
    }

    public static void LoadResources(string reName,string filePath)
    {
        AssetBundle ab = AssetBundle.LoadFromFile(@"H:\0.0\MyDemo\FishingJoy\AssetBundles\"+filePath);
        GameObject go = ab.LoadAsset<GameObject>(reName);
        prefabs.Add(reName, go);
    }

    public static GameObject GetGameObject(string name)
    {
        return prefabs[name];
    }
}
