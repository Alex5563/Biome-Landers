using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScrapbook : MonoBehaviour {
    public GameObject menuToggle;
    public GameObject scrollToggle;

    void Update() {
        if (Input.GetKeyDown("p")) {
            menuToggle.SetActive(true);
            scrollToggle.SetActive(false);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }

    public void Resume() {
        menuToggle.SetActive(false);
        scrollToggle.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void mainMenu() {
        SceneManager.LoadSceneAsync("Main menu");
    }

    public void QuitGame() {
        SceneManager.LoadSceneAsync("Main menu");
    }
}
