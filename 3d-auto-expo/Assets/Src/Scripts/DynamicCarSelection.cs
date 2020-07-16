using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DynamicCarSelection : MonoBehaviour
{
    public GameObject[] cars;
    public Button[] btnCars;
    public GameObject featuresMenu, compMenu;
    public Text price, mileage, engine, transmission;
    public GameObject IndicaComp;

    AssetBundle myAssetBundle;

    public string path;
    public string carName;

    private int i;
    public void SelectCar(int index)
    {
        featuresMenu.SetActive(true);
        compMenu.SetActive(true);

        if (index == 1)
        {
            i = 1;
            SelectCarFirst();
        }
        else if (index == 2)
        {
            i = 2;
            SelectCarSecond();
        }
        else if (index == 0)
        {
            i = 0;
            SelectCarNaught();
        }
    }

    IEnumerator StartCarLoading(string carAssetName) {
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

    void SelectCarNaught()
    {
        CarNaughtCanvas();
        StartCoroutine(StartCarLoading("car1"));

        //cars[i].SetActive(true);
        //cars[1].SetActive(false);        
        //cars[2].SetActive(false);             
    }

    

    void SelectCarFirst()
    {
        CarFirstCanvas();

        cars[i].SetActive(true);
        cars[0].SetActive(false);        
        cars[2].SetActive(false);
        
    }

    

    void SelectCarSecond()
    {
        CarSecondCanvas();

        cars[i].SetActive(true);        
        cars[0].SetActive(false);        
        cars[1].SetActive(false);        

        
    }

    void CarNaughtCanvas()
    {
        btnCars[i].GetComponent<Transform>().localScale = new Vector3(1.15f, 1.15f, 1.15f);
        btnCars[1].GetComponent<Transform>().localScale = new Vector3(0.8f, 0.8f, 0.8f);
        btnCars[2].GetComponent<Transform>().localScale = new Vector3(0.8f, 0.8f, 0.8f);

        price.text = "10,00,000/-";
        mileage.text = "15kmpl";
        engine.text = "1500cc";
        transmission.text = "Manual";

        IndicaComp.SetActive(true);
    }

    void CarFirstCanvas()
    {
        btnCars[i].GetComponent<Transform>().localScale = new Vector3(1.15f, 1.15f, 1.15f);
        btnCars[0].GetComponent<Transform>().localScale = new Vector3(0.8f, 0.8f, 0.8f);
        btnCars[2].GetComponent<Transform>().localScale = new Vector3(0.8f, 0.8f, 0.8f);

        price.text = "20,00,000/-";
        mileage.text = "10kmpl";
        engine.text = "2000cc";
        transmission.text = "Manual/AMT";

        IndicaComp.SetActive(false);
    }

    void CarSecondCanvas() {
        btnCars[i].GetComponent<Transform>().localScale = new Vector3(1.15f, 1.15f, 1.15f);
        btnCars[0].GetComponent<Transform>().localScale = new Vector3(0.8f, 0.8f, 0.8f);
        btnCars[1].GetComponent<Transform>().localScale = new Vector3(0.8f, 0.8f, 0.8f);

        price.text = "30,00,000/-";
        mileage.text = "5kmpl";
        engine.text = "3000cc";
        transmission.text = "Manual/AMT";

        IndicaComp.SetActive(false);
    }
}
