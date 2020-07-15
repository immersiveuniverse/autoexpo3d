using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlusMinusMenu : MonoBehaviour
{
    private bool boolFeatureMenu, boolFooterMenu = false;
    public Animator FeatureMenu, FooterMenu;
    public Button BtnFeatureMenu, BtnFooterMenu;
    public Sprite add, sub;

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
    /*
    public void AnimFooterMenu()
    {
        if (!boolFooterMenu)
        {
            boolFooterMenu = true;
            FooterMenu.SetBool("BoolFooterMenu", boolFooterMenu);
            BtnFooterMenu.GetComponent<Image>().sprite = add;
        }
        else
        {
            boolFooterMenu = false;
            FooterMenu.SetBool("BoolFooterMenu", boolFooterMenu);
            BtnFooterMenu.GetComponent<Image>().sprite = sub;
        }
    }
    */
}
