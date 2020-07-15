using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public class AssetLoader : MonoBehaviour
{

    public string bundleURL = "https://drive.google.com/drive/folders/1CnOx1IY8EtwzoA2ODr4VvhwqMC1SzRw7?usp=sharing";
    public string assetName = "ab-car1";

    IEnumerator Start()
    {
        using (WWW web = new WWW(bundleURL)) {
            yield return web;

            AssetBundle remoteAssetBundle = web.assetBundle;
            if (remoteAssetBundle == null) {
                Debug.LogError("Adso failed to download Asset Bundle");
            }
            Instantiate(remoteAssetBundle.LoadAsset(assetName));
            //remoteAssetBundle.Unload(false);
        }
        
    }
}
