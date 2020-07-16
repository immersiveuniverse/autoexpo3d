using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorVariant : MonoBehaviour
{
    public GameObject[] cars;
    public Button[] colors;
    public Material m1, m2, m3;
    public Material[] m;
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
        cars[1].GetComponent<Renderer>().material = m[1];
    }

    void SecondColor()
    {
        cars[1].GetComponent<Renderer>().material = m[1];
    }

    void ThirdColor()
    {
        cars[1].GetComponent<Renderer>().material = m[1];
    }
}
