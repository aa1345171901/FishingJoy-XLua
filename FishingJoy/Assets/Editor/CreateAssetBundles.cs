using System.IO;
using UnityEditor;

public class CreateAssetBundles
{
    [MenuItem("Assets/CrateAllAssetBundles")]
    static void CreateAllAssetBundles()
    {
        string dir = @"H:\0.0\MyDemo\FishingJoy\AssetBundles";
        if (Directory.Exists(dir)==false)
        {
            Directory.CreateDirectory(dir);
        }
        BuildPipeline.BuildAssetBundles(dir,BuildAssetBundleOptions.None,BuildTarget.StandaloneWindows64);
    }
}
