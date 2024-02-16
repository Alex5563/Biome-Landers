using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour {
    public GameObject menuToggle;
    public GameObject coinToggle;
    public PlayerCam moveCam;
    public PlayerMovement movementToggle;

    void Update() {
        if (Input.GetKeyDown("p")) {
            menuToggle.SetActive(true);
            coinToggle.SetActive(false);
            moveCam.enabled = false;
            movementToggle.enabled = false;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }

    public void Resume() {
        menuToggle.SetActive(false);
        coinToggle.SetActive(true);
        moveCam.enabled = true;
        movementToggle.enabled = true;
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
