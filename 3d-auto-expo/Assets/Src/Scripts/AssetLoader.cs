using UnityEngine;
using UnityEngine.Networking;
using System.Collections;
using System.IO;

public class AssetLoader : MonoBehaviour
{
    AssetBundle myAssetBundle;

    public string path;
    public string carName;

    void Start()
    {
        LoadAssetBundle(path);
        InstantiateAsset(carName);
    }

    void LoadAssetBundle(string bundleURL) {
        //myAssetBundle = AssetBundle.LoadFromFile(Path.Combine(Application.streamingAssetsPath, bundleURL));
        myAssetBundle = AssetBundle.LoadFromFile(bundleURL);
        Debug.Log(myAssetBundle == null? "Failed":"Success");
    }

    void InstantiateAsset(string assetName) {
        var prefab = myAssetBundle.LoadAsset(assetName);
        Instantiate(prefab);
    }
}

