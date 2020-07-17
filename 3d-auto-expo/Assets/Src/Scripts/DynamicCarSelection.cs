using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DynamicCarSelection : MonoBehaviour
{
    public Button[] btnCars;
    public GameObject featuresMenu, compMenu;
    public Text price, mileage, engine, transmission;
    public GameObject IndicaComp, CarsContainer;
    //public GameObject checkCarStatus;

    AssetBundle myAssetBundle;

    public string path;
    //public string carName;

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

    private bool car0, car1, car2, boolcarA, boolcarB, boolcarC = false;
    public GameObject carA, carB, carC;
    IEnumerator StartCarLoading(string carAssetName, int index) {
        using (WWW web = new WWW(path))
        {
            yield return web;
            AssetBundle remoteAsset = web.assetBundle;

            if (remoteAsset == null)
            {
                Debug.Log("Failed");
                yield break;
            }

            GameObject myCar = remoteAsset.LoadAsset(carAssetName) as GameObject;

            if (!car0 && !car1 && !car2)
            {
                Debug.Log("All");
                if (myCar.name.Equals("car1") && carAssetName.Equals("car1"))
                {
                    carA = Instantiate(myCar, CarsContainer.transform) as GameObject;
                    car0 = true;
                }
                else if (myCar.name.Equals("car2") && carAssetName.Equals("car2"))
                {
                    carB = Instantiate(myCar, CarsContainer.transform) as GameObject;
                    car1 = true;
                }
                else if (myCar.name.Equals("car3") && carAssetName.Equals("car3"))
                {
                    carC = Instantiate(myCar, CarsContainer.transform) as GameObject;
                    car2 = true;
                }
            }
            else {
                if (car0 && !boolcarA)
                {
                    Debug.Log("car0");
                    carA.SetActive(false);
                    if (myCar.name.Equals("car2") && carAssetName.Equals("car2"))
                    {
                        carB = Instantiate(myCar, CarsContainer.transform) as GameObject;
                        car1 = true;
                    }
                    else if (myCar.name.Equals("car3") && carAssetName.Equals("car3"))
                    {
                        carC = Instantiate(myCar, CarsContainer.transform) as GameObject;
                        car2 = true;
                    }
                    boolcarA = true;
                }else if (car1 && !boolcarB)
                {
                    Debug.Log("car1");
                    carB.SetActive(false);
                    if (myCar.name.Equals("car1") && carAssetName.Equals("car1"))
                    {
                        carA = Instantiate(myCar, CarsContainer.transform) as GameObject;
                        car0 = true;
                    }
                    else if (myCar.name.Equals("car3") && carAssetName.Equals("car3"))
                    {
                        carC = Instantiate(myCar, CarsContainer.transform) as GameObject;
                        car2 = true;
                    }
                    boolcarB = true;
                }
                else if (car2 && !boolcarC)
                {
                    Debug.Log("car2");
                    carC.SetActive(false);
                    if (myCar.name.Equals("car1") && carAssetName.Equals("car1"))
                    {
                        carA = Instantiate(myCar, CarsContainer.transform) as GameObject;
                        car0 = true;
                    }
                    else if (myCar.name.Equals("car2") && carAssetName.Equals("car2"))
                    {
                        carB = Instantiate(myCar, CarsContainer.transform) as GameObject;
                        car1 = true;
                    }
                    boolcarC = true;
                }
            }

            

            
            remoteAsset.Unload(false);
        }
    }

    void SelectCarNaught()
    {
        CarNaughtCanvas();

        if (!car0) {
            StartCoroutine(StartCarLoading("car1", 0));
        }
        else {
            carA.SetActive(true);
            carB.SetActive(false);
            carC.SetActive(false);

        }
    }

    void SelectCarFirst()
    {
        CarFirstCanvas();

        if (!car1)
        {
            StartCoroutine(StartCarLoading("car2", 1));
        }
        else
        {
            carA.SetActive(false);
            carB.SetActive(true);
            carC.SetActive(false);
        }
    }

    void SelectCarSecond()
    {
        CarSecondCanvas();

        if (!car2)
        {
            StartCoroutine(StartCarLoading("car3", 2));
        }
        else
        {
            carA.SetActive(false);
            carB.SetActive(false);
            carC.SetActive(true);
        }
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
