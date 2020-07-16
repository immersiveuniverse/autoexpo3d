using UnityEngine;
using UnityEngine.Networking;
using System.Collections;
using System.IO;

public class AssetLoader : MonoBehaviour
{
    AssetBundle myAssetBundle;
    AssetBundleCreateRequest myRequest;


    public string path;
    public string carName;

    void Start()
    {
        LoadAssetBundle(path);
        InstantiateAsset(carName);
    }

    void LoadAssetBundle(string bundleURL) {
        //myRequest = AssetBundle.LoadFromFileAsync(Path.Combine(Application.streamingAssetsPath, bundleURL));
        myRequest = AssetBundle.LoadFromFileAsync(bundleURL);
        myAssetBundle = myRequest.assetBundle;

        //Debug.Log(myAssetBundle == null? "Failed":"Success");
        Debug.Log(bundleURL);
    }

    void InstantiateAsset(string assetName) {
        var assetRequest = myAssetBundle.LoadAssetAsync(assetName);
        var prefab = assetRequest.asset;
        Instantiate(prefab);
    }
}

