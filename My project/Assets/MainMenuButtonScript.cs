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
        SceneManager.LoadSceneAsync("Main menu");
    }
    public void openscrapbook()
    {
        SceneManager.LoadSceneAsync("Scrapbook");
    }
 
}