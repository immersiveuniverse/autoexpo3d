using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlusMinusMenu : MonoBehaviour
{
    private bool boolFeatureMenu, boolCompMenu = false;
    public Animator FeatureMenu, CompMenu, CarAnimator;
    public Button BtnFeatureMenu, BtnCompMenu;
    public Sprite add, sub;

    private void Update()
    {
        if (boolCompMenu && boolFeatureMenu) {
            CarAnimator.enabled = false;
        }
    }

    public void AnimFeatureMenu()
    {
        if (!boolFeatureMenu)
        {
            boolFeatureMenu = true;
            FeatureMenu.SetBool("boolCloseOpen", boolFeatureMenu);
            BtnFeatureMenu.GetComponent<Image>().sprite = add;
            
        }
        else
        {
            boolFeatureMenu = false;
            FeatureMenu.SetBool("boolCloseOpen", boolFeatureMenu);
            BtnFeatureMenu.GetComponent<Image>().sprite = sub;
        }
    }
    
    public void AnimCompMenu()
    {
        if (!boolCompMenu)
        {
            boolCompMenu = true;
            CompMenu.SetBool("boolCompMenu", boolCompMenu);
            BtnCompMenu.GetComponent<Image>().sprite = add;            
        }
        else
        {
            boolCompMenu = false;
            CompMenu.SetBool("boolCompMenu", boolCompMenu);
            BtnCompMenu.GetComponent<Image>().sprite = sub;
        }
    }
    
}
