using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;

public class AssetBundleManager : MonoBehaviour
{
    [MenuItem("Assets/Build AssetBundles")]
    static void BuildAllAssetBundles() {
        string abDir = "Assets/AssetBundles";

        if (!Directory.Exists(Application.streamingAssetsPath)) {
            Directory.CreateDirectory(abDir);
        }

        BuildPipeline.BuildAssetBundles(abDir, BuildAssetBundleOptions.None, EditorUserBuildSettings.activeBuildTarget);
    }
}
