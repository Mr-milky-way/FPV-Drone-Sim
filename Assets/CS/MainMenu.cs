using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //play Freestyle
    public void PlayN()
    {
        SceneManager.LoadSceneAsync(1);
    }

    //Play racing
    public void PlayR()
    {
        SceneManager.LoadSceneAsync(2);
    }

    //Play multiplayer
    public void Playultiplayer()
    {
        SceneManager.LoadSceneAsync(3);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
