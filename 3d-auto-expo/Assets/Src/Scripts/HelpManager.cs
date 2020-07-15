using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HelpManager : MonoBehaviour
{
    public bool boolHelp = false;
    public Button btnClose, btnHelp;
    public GameObject HelpPanel;

    public void PanelHelping() {
        if (!boolHelp)
        {
            HelpPanel.SetActive(true);
            boolHelp = true;
        }
        else {
            HelpPanel.SetActive(false);
            boolHelp = false;
        }
    }

    public void HelpClose() {
        HelpPanel.SetActive(false);
        boolHelp = false;
    }
}
