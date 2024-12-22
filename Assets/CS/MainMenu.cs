using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayN()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void PlayR()
    {
        SceneManager.LoadSceneAsync(2);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
