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
        GameObject prefab = myAssetBundle.LoadAsset<GameObject>(assetName);
        Instantiate(prefab, new Vector3(0f, -27f, 50f), Quaternion.Euler(0f, 90f, 0f));
    }
}

