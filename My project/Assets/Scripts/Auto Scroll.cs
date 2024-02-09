using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BgScroll : MonoBehaviour
{
    private RawImage bgImage;
    [SerializeField] float speedX, speedY;
    // Start is called before the first frame update
    void Start()
    {
        bgImage = GetComponent<RawImage>();
    }

    // Update is called once per frame
    void Update()
    {
        bgImage.uvRect = new Rect(bgImage.uvRect.position + new Vector2(speedX, speedY) * Time.deltaTime, bgImage.uvRect.size);
    }
}