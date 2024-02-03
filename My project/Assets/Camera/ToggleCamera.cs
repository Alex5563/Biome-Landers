using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleCamera : MonoBehaviour {
    public GameObject toggle;

    void Update() {
       if (Input.GetKeyDown("c")) {
            if (toggle.activeInHierarchy == true)
                toggle.SetActive(false);
            else
                toggle.SetActive(true);
       }
    }
}
