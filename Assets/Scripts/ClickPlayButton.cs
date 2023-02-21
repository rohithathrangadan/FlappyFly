using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


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
        Invoke(nameof(StartGame), 0.5f);
        //_audio.PlayOneShot(ExpandedAudio);
    }

    void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

   public void onClick()
    {
        Debug.Log("Play button Clicked");
    }
}
