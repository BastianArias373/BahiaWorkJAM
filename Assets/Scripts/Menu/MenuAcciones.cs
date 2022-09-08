using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuAcciones : MonoBehaviour
{

    public int escena = 1;
    public void play()
    {
        SceneManager.LoadScene(escena);
        OnContinue();
    }

    public void creditos()
    {

    }

    public void exit()
    {
        Application.Quit();
    }

    public void OnPause()
    {
        Time.timeScale = 0f;
    }

    public void OnContinue()
    {
        Time.timeScale = 1f;
    }
}
