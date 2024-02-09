using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour {
    public GameObject menuToggle;
    public GameObject coinToggle;

    void Update() {
        if (Input.GetKeyDown("p")) {
            menuToggle.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }

    public void Resume() {
        menuToggle.SetActive(false);
        coinToggle.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void mainMenu() {
        SceneManager.LoadSceneAsync("Main menu");
    }

    public void QuitGame() {
        Application.Quit();
    }
}
