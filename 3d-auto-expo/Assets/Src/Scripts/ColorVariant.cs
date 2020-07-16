using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorVariant : MonoBehaviour
{
    public GameObject[] cars;
    public Button[] colors;
    public Material m1, m2, m3;

    private int i;
    public void SelectColor(int index) {
        if (index == 0)
        {
            i = 0;
            FirstColor();
            
        }
        else if (index == 1)
        {
            i = 1;
            SecondColor();
        }
        else if (index == 2)
        {
            i = 2;
            ThirdColor();
        }
    }

    void FirstColor() {
        cars[0].GetComponent<Renderer>().material = m1;
        Debug.Log(cars[0].GetComponent<Renderer>().material);
        Debug.Log(cars[0].GetComponent<Renderer>().materials);
        Debug.Log(cars[0].GetComponent<Renderer>().materials[0]);
    }

    void SecondColor()
    {
        cars[0].GetComponent<Renderer>().material = m2;
        Debug.Log(cars[0].GetComponent<Renderer>().material);
        Debug.Log(cars[0].GetComponent<Renderer>().materials);
        Debug.Log(cars[0].GetComponent<Renderer>().materials[0]);
    }

    void ThirdColor()
    {
        cars[0].GetComponent<Renderer>().material = m3;
        Debug.Log(cars[0].GetComponent<Renderer>().material);
        Debug.Log(cars[0].GetComponent<Renderer>().materials);
        Debug.Log(cars[0].GetComponent<Renderer>().materials[0]);
    }
}
