using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CarARAnim : MonoBehaviour
{
    public Animator CarAnimator;
    public Button btnExpand;
    private bool boolExpand = false;

    public void AnimExpand()
    {
        CarAnimator.enabled = true;
        if (!boolExpand)
        {
            boolExpand = true;
            CarAnimator.SetBool("boolExpand", boolExpand);
            btnExpand.GetComponent<Transform>().localScale = new Vector3(1.1f, 1.1f, 1.1f);
        }
        else
        {
            boolExpand = false;
            CarAnimator.SetBool("boolExpand", false);
            btnExpand.GetComponent<Transform>().localScale = new Vector3(0.9f, 0.9f, 0.9f);
        }
    }
}
