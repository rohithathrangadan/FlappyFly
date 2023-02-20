using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class ClickPlayButton : MonoBehaviour,IPointerDownHandler,IPointerUpHandler
{
    [SerializeField] Image _image;
    [SerializeField] Sprite _buttonCompressed, _buttonExpanded;
    [SerializeField] AudioClip CompressedAudio, ExpandedAudio;
    [SerializeField] AudioSource _audio;

    public void OnPointerDown(PointerEventData eventData)
    {
        _image.sprite = _buttonCompressed;
        _audio.PlayOneShot(CompressedAudio);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        _image.sprite = _buttonExpanded;
        //_audio.PlayOneShot(ExpandedAudio);
    }

   public void onClick()
    {
        Debug.Log("Play button Clicked");
    }
}
