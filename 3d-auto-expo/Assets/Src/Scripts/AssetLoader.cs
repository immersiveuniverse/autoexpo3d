using UnityEngine;
using UnityEngine.Networking;
using System.Collections;
using System.IO;

public class AssetLoader : MonoBehaviour
{
    AssetBundle myAssetBundle;

    public string path;
    public string carName;

    IEnumerator Start()
    {
        using (WWW web = new WWW(path))
        {
            yield return web;
            AssetBundle remoteAsset = web.assetBundle;
            
            if (remoteAsset == null)
            {
                Debug.Log("Failed");
                yield break;
            }

            Instantiate(remoteAsset.LoadAsset(carName));
            remoteAsset.Unload(false);

        }
    }
}

