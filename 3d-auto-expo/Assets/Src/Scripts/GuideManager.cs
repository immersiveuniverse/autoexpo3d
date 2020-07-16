using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GuideManager : MonoBehaviour
{
    private bool boolGuide;
    private int boolShow = 0;

    public GameObject GuidePanel;
    public Image imgDontShowPopUp;
    public Sprite imgCheck, imgUncheck;

    public void GuidePop()
    {
        if (boolGuide)
        {
            boolGuide = false;
            GuidePanel.SetActive(false);
        }
        else
        {
            boolGuide = true;
            GuidePanel.SetActive(true);
        }
    }


    void Start()
    {
        boolShow = PlayerPrefs.GetInt(SceneManager.GetActiveScene().name);

        if (boolShow == 0)
        {
            GuidePanel.SetActive(true);
            boolGuide = true;
            imgDontShowPopUp.GetComponent<Image>().sprite = imgUncheck;
            Debug.Log("Awake " + SceneManager.GetActiveScene().name + " " + boolShow);
        }
        else
        {
            GuidePanel.SetActive(false);
            boolGuide = false;
            imgDontShowPopUp.GetComponent<Image>().sprite = imgCheck;
            Debug.Log("Awake " + SceneManager.GetActiveScene().name + " " + boolShow);
        }
    }

    public void DontShowPop()
    {
        if (boolShow == 0)
        {
            boolShow = 1;
            //activeSceneIndex = SceneManager.GetActiveScene().buildIndex;
            PlayerPrefs.SetInt(SceneManager.GetActiveScene().name, boolShow);
            imgDontShowPopUp.GetComponent<Image>().sprite = imgCheck;
            Debug.Log("F " + SceneManager.GetActiveScene().name + " " + boolShow);
        }
        else
        {
            boolShow = 0;
            //activeSceneIndex = SceneManager.GetActiveScene().buildIndex;
            PlayerPrefs.SetInt(SceneManager.GetActiveScene().name, boolShow);
            imgDontShowPopUp.GetComponent<Image>().sprite = imgUncheck;
            Debug.Log("F " + SceneManager.GetActiveScene().name + " " + boolShow);
        }
    }
}
