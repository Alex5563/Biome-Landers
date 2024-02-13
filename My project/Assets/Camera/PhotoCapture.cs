using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class PhotoCapture : MonoBehaviour {
    [SerializeField] private Image photoDisplayArea;
    [SerializeField] private GameObject photoFrame;
    [SerializeField] private GameObject cameraFrame;
    [SerializeField] private AudioSource cameraAudio;
    [SerializeField] private Book book;
    [SerializeField] private GameObject portalText;

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

        if (portalText.activeInHierarchy == true) {
            portalText.SetActive(false);
        }

        yield return new WaitForEndOfFrame();

        Rect regionToRead = new Rect(0, 0, Screen.width, Screen.height);

        screenCapture.ReadPixels(regionToRead, 0, 0, false);
        screenCapture.Apply();
        ShowPhoto();
    }

    void ShowPhoto() {
        string filePath = SavePhotoAsPNG(screenCapture);

        Texture2D loadedTexture = LoadTextureFromFile(filePath);

        book.UpdateBookPages(loadedTexture);

        Sprite photoSprite = Sprite.Create(screenCapture, new Rect(0.0f, 0.0f, screenCapture.width, screenCapture.height), new Vector2(0.5f, 0.5f), 100.0f);
        photoDisplayArea.sprite = photoSprite;

        photoFrame.SetActive(true);
    }

    string SavePhotoAsPNG(Texture2D texture) {
        byte[] bytes = texture.EncodeToPNG();
        string filePath = Application.persistentDataPath + "/captured_photo.png";
        File.WriteAllBytes(filePath, bytes);
        return filePath;
    }

    Texture2D LoadTextureFromFile(string filePath) {
        byte[] fileData = File.ReadAllBytes(filePath);
        Texture2D loadedTexture = new Texture2D(2, 2);
        loadedTexture.LoadImage(fileData);

        loadedTexture = CenterCropTexture(loadedTexture, 720, 720);

        return loadedTexture;
    }

    Texture2D CenterCropTexture(Texture2D source, int newWidth, int newHeight) {
        int startX = (source.width - newWidth) / 2;
        int startY = (source.height - newHeight) / 2;

        return CropTexture(source, startX, startY, newWidth, newHeight);
    }

    Texture2D CropTexture(Texture2D source, int startX, int startY, int newWidth, int newHeight) {
        Color[] pixels = source.GetPixels(startX, startY, newWidth, newHeight);
        Texture2D croppedTexture = new Texture2D(newWidth, newHeight);
        croppedTexture.SetPixels(pixels);
        croppedTexture.Apply();
        return croppedTexture;
    }

    void RemovePhoto() {
        viewingPhoto = false;
        photoFrame.SetActive(false);
        cameraFrame.SetActive(true);
    }
}