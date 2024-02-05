using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PhotoCapture : MonoBehaviour {
    [SerializeField] private Image photoDisplayArea;
    [SerializeField] private GameObject photoFrame;
    [SerializeField] private GameObject cameraFrame;
    [SerializeField] private AudioSource cameraAudio;
    [SerializeField] private Book book;

    private Texture2D screenCapture;
    private bool viewingPhoto;

    private void Start() {
        screenCapture = new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24, false);
    }

    private void Update() {
        if (Input.GetKeyDown("f")) {
            if (!viewingPhoto) {
               StartCoroutine(CapturePhoto());
               cameraAudio.Play();
            }
            
            else {
                RemovePhoto();
            }

        }
    }

    IEnumerator CapturePhoto() {
        cameraFrame.SetActive(false);
        viewingPhoto = true;
        yield return new WaitForEndOfFrame();

        Rect regionToRead = new Rect(0, 0, Screen.width, Screen.height);

        screenCapture.ReadPixels(regionToRead, 0, 0, false);
        screenCapture.Apply();
        ShowPhoto();
    }

    void ShowPhoto() {
        Sprite photoSprite = Sprite.Create(screenCapture, new Rect(0.0f, 0.0f, screenCapture.width, screenCapture.height), new Vector2(0.5f, 0.5f), 100.0f);
        photoDisplayArea.sprite = photoSprite;

        photoFrame.SetActive(true);
        book.UpdateBookPages(photoSprite);
    }

    void RemovePhoto() {
        viewingPhoto = false;
        photoFrame.SetActive(false);
        cameraFrame.SetActive(true);
    }

}