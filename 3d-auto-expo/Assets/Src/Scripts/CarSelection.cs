﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarSelection : MonoBehaviour
{
    public GameObject[] cars;
    public Button[] btnCars;
    public GameObject featuresMenu, compMenu;
    public Text price, mileage, engine, transmission;
    public GameObject IndicaComp;
    public Material m1, m2, m3;

    private int i;
    public void SelectCar(int index) {
        featuresMenu.SetActive(true);
        compMenu.SetActive(true);

        if (index == 1) {
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

    void SelectCarNaught()
    {
        cars[i].SetActive(true);
        btnCars[i].GetComponent<Transform>().localScale = new Vector3(1.15f, 1.15f, 1.15f);
        cars[1].SetActive(false);
        btnCars[1].GetComponent<Transform>().localScale = new Vector3(0.8f, 0.8f, 0.8f);
        cars[2].SetActive(false);
        btnCars[2].GetComponent<Transform>().localScale = new Vector3(0.8f, 0.8f, 0.8f);

        price.text = "10,00,000/-";
        mileage.text = "15kmpl";
        engine.text = "1500cc";
        transmission.text = "Manual";

        IndicaComp.SetActive(true);
    }

    void SelectCarFirst() {
        cars[i].SetActive(true);
        btnCars[i].GetComponent<Transform>().localScale = new Vector3(1.15f, 1.15f, 1.15f);
        cars[0].SetActive(false);
        btnCars[0].GetComponent<Transform>().localScale = new Vector3(0.8f, 0.8f, 0.8f);
        cars[2].SetActive(false);
        btnCars[2].GetComponent<Transform>().localScale = new Vector3(0.8f, 0.8f, 0.8f);

        price.text = "20,00,000/-";
        mileage.text = "10kmpl";
        engine.text = "2000cc";
        transmission.text = "Manual/AMT";

        IndicaComp.SetActive(false);

    }

    void SelectCarSecond() {
        cars[i].SetActive(true);
        btnCars[i].GetComponent<Transform>().localScale = new Vector3(1.15f, 1.15f, 1.15f);
        cars[0].SetActive(false);
        btnCars[0].GetComponent<Transform>().localScale = new Vector3(0.8f, 0.8f, 0.8f);
        cars[1].SetActive(false);
        btnCars[1].GetComponent<Transform>().localScale = new Vector3(0.8f, 0.8f, 0.8f);

        price.text = "30,00,000/-";
        mileage.text = "5kmpl";
        engine.text = "3000cc";
        transmission.text = "Manual/AMT";

        IndicaComp.SetActive(false);
    }

    
}
