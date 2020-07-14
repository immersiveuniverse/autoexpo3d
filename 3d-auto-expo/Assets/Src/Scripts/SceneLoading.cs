using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoading : MonoBehaviour
{
    public void LoadMySceneInteger(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }

    public void LoadMySceneString(string sceneString)
    {
        SceneManager.LoadScene(sceneString);
    }

    public void ReloadMyScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void QuitApp() {
        Application.Quit();
    }
}
