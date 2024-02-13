using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync("Opening Dialogue");
    }
    public void quitgame()
    {
        Application.Quit();
    }
    public void openscrapbook()
    {
        SceneManager.LoadSceneAsync("THE END");
    }
 
}