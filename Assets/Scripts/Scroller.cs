using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scroller : MonoBehaviour
{
    [SerializeField] RawImage _image;
    [SerializeField] float x, y;
    //get reference to the raw image for scroll
    //access the rect property of the image

    private void Update()
    {
        _image.uvRect = new Rect(_image.uvRect.position + new Vector2(x, y) * Time.deltaTime, _image.uvRect.size);
    }
}
