using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toggle : MonoBehaviour {
    public GameObject cameraToggle;
    public GameObject bookToggle;
    public GameObject coinToggle;
    public PlayerCam moveCam;
    public PlayerMovement movementToggle;

    void Update() {
       if (Input.GetKeyDown("c")) {
            if (cameraToggle.activeInHierarchy == true)
                cameraToggle.SetActive(false);
            else
                cameraToggle.SetActive(true);
       }

        if (Input.GetKeyDown("i")) {
            if (bookToggle.activeInHierarchy == true) {
            bookToggle.SetActive(false);
            moveCam.enabled = true;
            movementToggle.enabled = true;
            cameraToggle.SetActive(true);
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
        else {
            bookToggle.SetActive(true);
            moveCam.enabled = false;
            movementToggle.enabled = false;
            cameraToggle.SetActive(false);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        }   
    }
}
